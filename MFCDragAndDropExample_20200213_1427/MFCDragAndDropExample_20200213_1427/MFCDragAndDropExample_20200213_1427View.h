
// MFCDragAndDropExample_20200213_1427View.h : interface of the CMFCDragAndDropExample202002131427View class
//

#pragma once


class CMFCDragAndDropExample202002131427View : public CView
{
protected: // create from serialization only
	CMFCDragAndDropExample202002131427View() noexcept;
	DECLARE_DYNCREATE(CMFCDragAndDropExample202002131427View)

// Attributes
public:
	CMFCDragAndDropExample202002131427Doc* GetDocument() const;

// Operations
public:

// Overrides
public:
	virtual void OnDraw(CDC* pDC);  // overridden to draw this view
	virtual BOOL PreCreateWindow(CREATESTRUCT& cs);
protected:
	virtual BOOL OnPreparePrinting(CPrintInfo* pInfo);
	virtual void OnBeginPrinting(CDC* pDC, CPrintInfo* pInfo);
	virtual void OnEndPrinting(CDC* pDC, CPrintInfo* pInfo);

// Implementation
public:
	virtual ~CMFCDragAndDropExample202002131427View();
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif

protected:

// Generated message map functions
protected:
	DECLARE_MESSAGE_MAP()
};

#ifndef _DEBUG  // debug version in MFCDragAndDropExample_20200213_1427View.cpp
inline CMFCDragAndDropExample202002131427Doc* CMFCDragAndDropExample202002131427View::GetDocument() const
   { return reinterpret_cast<CMFCDragAndDropExample202002131427Doc*>(m_pDocument); }
#endif

