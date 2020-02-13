
// MFCDragAndDropExample_20200213_1427Doc.cpp : implementation of the CMFCDragAndDropExample202002131427Doc class
//

#include "stdafx.h"
// SHARED_HANDLERS can be defined in an ATL project implementing preview, thumbnail
// and search filter handlers and allows sharing of document code with that project.
#ifndef SHARED_HANDLERS
#include "MFCDragAndDropExample_20200213_1427.h"
#endif

#include "MFCDragAndDropExample_20200213_1427Doc.h"

#include <propkey.h>

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

// CMFCDragAndDropExample202002131427Doc

IMPLEMENT_DYNCREATE(CMFCDragAndDropExample202002131427Doc, CDocument)

BEGIN_MESSAGE_MAP(CMFCDragAndDropExample202002131427Doc, CDocument)
END_MESSAGE_MAP()


// CMFCDragAndDropExample202002131427Doc construction/destruction

CMFCDragAndDropExample202002131427Doc::CMFCDragAndDropExample202002131427Doc() noexcept
{
	// TODO: add one-time construction code here

}

CMFCDragAndDropExample202002131427Doc::~CMFCDragAndDropExample202002131427Doc()
{
}

BOOL CMFCDragAndDropExample202002131427Doc::OnNewDocument()
{
	if (!CDocument::OnNewDocument())
		return FALSE;

	// TODO: add reinitialization code here
	// (SDI documents will reuse this document)

	return TRUE;
}




// CMFCDragAndDropExample202002131427Doc serialization

void CMFCDragAndDropExample202002131427Doc::Serialize(CArchive& ar)
{
	if (ar.IsStoring())
	{
		// TODO: add storing code here
	}
	else
	{
		// TODO: add loading code here
	}
}

#ifdef SHARED_HANDLERS

// Support for thumbnails
void CMFCDragAndDropExample202002131427Doc::OnDrawThumbnail(CDC& dc, LPRECT lprcBounds)
{
	// Modify this code to draw the document's data
	dc.FillSolidRect(lprcBounds, RGB(255, 255, 255));

	CString strText = _T("TODO: implement thumbnail drawing here");
	LOGFONT lf;

	CFont* pDefaultGUIFont = CFont::FromHandle((HFONT) GetStockObject(DEFAULT_GUI_FONT));
	pDefaultGUIFont->GetLogFont(&lf);
	lf.lfHeight = 36;

	CFont fontDraw;
	fontDraw.CreateFontIndirect(&lf);

	CFont* pOldFont = dc.SelectObject(&fontDraw);
	dc.DrawText(strText, lprcBounds, DT_CENTER | DT_WORDBREAK);
	dc.SelectObject(pOldFont);
}

// Support for Search Handlers
void CMFCDragAndDropExample202002131427Doc::InitializeSearchContent()
{
	CString strSearchContent;
	// Set search contents from document's data.
	// The content parts should be separated by ";"

	// For example:  strSearchContent = _T("point;rectangle;circle;ole object;");
	SetSearchContent(strSearchContent);
}

void CMFCDragAndDropExample202002131427Doc::SetSearchContent(const CString& value)
{
	if (value.IsEmpty())
	{
		RemoveChunk(PKEY_Search_Contents.fmtid, PKEY_Search_Contents.pid);
	}
	else
	{
		CMFCFilterChunkValueImpl *pChunk = nullptr;
		ATLTRY(pChunk = new CMFCFilterChunkValueImpl);
		if (pChunk != nullptr)
		{
			pChunk->SetTextValue(PKEY_Search_Contents, value, CHUNK_TEXT);
			SetChunkValue(pChunk);
		}
	}
}

#endif // SHARED_HANDLERS

// CMFCDragAndDropExample202002131427Doc diagnostics

#ifdef _DEBUG
void CMFCDragAndDropExample202002131427Doc::AssertValid() const
{
	CDocument::AssertValid();
}

void CMFCDragAndDropExample202002131427Doc::Dump(CDumpContext& dc) const
{
	CDocument::Dump(dc);
}
#endif //_DEBUG


// CMFCDragAndDropExample202002131427Doc commands
