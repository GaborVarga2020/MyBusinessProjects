#pragma once

#include "CMyOleDropTarget.h"		// (Implemented by VargaG., on 2020.02.13.)

class CMFCDragAndDropExample202002131427View : public CView
{
	// Provides the communication mechanism between a window and the OLE libraries.
	// (Implemented by VargaG., on 2020.02.13.)
private: CMyOleDropTarget m_oleDropTarget;

protected: afx_msg int OnCreate(LPCREATESTRUCT a_lpCreateStruct);		// (Implemented by VargaG., on 2020.02.13.)

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

