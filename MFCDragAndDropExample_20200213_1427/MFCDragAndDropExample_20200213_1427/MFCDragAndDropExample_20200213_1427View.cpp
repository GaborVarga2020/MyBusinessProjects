
// MFCDragAndDropExample_20200213_1427View.cpp : implementation of the CMFCDragAndDropExample202002131427View class
//

#include "stdafx.h"
// SHARED_HANDLERS can be defined in an ATL project implementing preview, thumbnail
// and search filter handlers and allows sharing of document code with that project.
#ifndef SHARED_HANDLERS
#include "MFCDragAndDropExample_20200213_1427.h"
#endif

#include "MFCDragAndDropExample_20200213_1427Doc.h"
#include "MFCDragAndDropExample_20200213_1427View.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CMFCDragAndDropExample202002131427View

IMPLEMENT_DYNCREATE(CMFCDragAndDropExample202002131427View, CView)

BEGIN_MESSAGE_MAP(CMFCDragAndDropExample202002131427View, CView)
	// Standard printing commands
	ON_COMMAND(ID_FILE_PRINT, &CView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_DIRECT, &CView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_PREVIEW, &CView::OnFilePrintPreview)
	ON_WM_CREATE()		// (Implemented by VargaG., on 2020.02.13.)
END_MESSAGE_MAP()

// CMFCDragAndDropExample202002131427View construction/destruction

CMFCDragAndDropExample202002131427View::CMFCDragAndDropExample202002131427View() noexcept
{
	// TODO: add construction code here

}

CMFCDragAndDropExample202002131427View::~CMFCDragAndDropExample202002131427View()
{
}

BOOL CMFCDragAndDropExample202002131427View::PreCreateWindow(CREATESTRUCT& cs)
{
	// TODO: Modify the Window class or styles here by modifying
	//  the CREATESTRUCT cs

	return CView::PreCreateWindow(cs);
}

// (Implemented by VargaG., on 2020.02.13.)
int CMFCDragAndDropExample202002131427View::OnCreate(LPCREATESTRUCT a_lpCreateStruct)
{
	// (Implemented by VargaG., on 2020.02.13.)
	if (CView::OnCreate(a_lpCreateStruct) == -1)
	{
		// (Implemented by VargaG., on 2020.02.13.)
		return -1;
	}

	// Register this window with the OLE DLLs as a valid drop target.
	// (Implemented by VargaG., on 2020.02.13.)
	if (m_oleDropTarget.Register(this) == FALSE)
	{
		// (Implemented by VargaG., on 2020.02.13.)
		ASSERT(FALSE);
		return -1;
	}

	// (Implemented by VargaG., on 2020.02.13.)
	return 0;
}

void CMFCDragAndDropExample202002131427View::OnDraw(CDC* /*pDC*/)
{
	CMFCDragAndDropExample202002131427Doc* pDoc = GetDocument();
	ASSERT_VALID(pDoc);
	if (!pDoc)
		return;

	// TODO: add draw code for native data here
}


// CMFCDragAndDropExample202002131427View printing

BOOL CMFCDragAndDropExample202002131427View::OnPreparePrinting(CPrintInfo* pInfo)
{
	// default preparation
	return DoPreparePrinting(pInfo);
}

void CMFCDragAndDropExample202002131427View::OnBeginPrinting(CDC* /*pDC*/, CPrintInfo* /*pInfo*/)
{
	// TODO: add extra initialization before printing
}

void CMFCDragAndDropExample202002131427View::OnEndPrinting(CDC* /*pDC*/, CPrintInfo* /*pInfo*/)
{
	// TODO: add cleanup after printing
}


// CMFCDragAndDropExample202002131427View diagnostics

#ifdef _DEBUG
void CMFCDragAndDropExample202002131427View::AssertValid() const
{
	CView::AssertValid();
}

void CMFCDragAndDropExample202002131427View::Dump(CDumpContext& dc) const
{
	CView::Dump(dc);
}

CMFCDragAndDropExample202002131427Doc* CMFCDragAndDropExample202002131427View::GetDocument() const // non-debug version is inline
{
	ASSERT(m_pDocument->IsKindOf(RUNTIME_CLASS(CMFCDragAndDropExample202002131427Doc)));
	return (CMFCDragAndDropExample202002131427Doc*)m_pDocument;
}
#endif //_DEBUG


// CMFCDragAndDropExample202002131427View message handlers
