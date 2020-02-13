
// MFCDragAndDropExample_20200213_1427.h : main header file for the MFCDragAndDropExample_20200213_1427 application
//
#pragma once

#ifndef __AFXWIN_H__
	#error "include 'stdafx.h' before including this file for PCH"
#endif

#include "resource.h"       // main symbols


// CMFCDragAndDropExample202002131427App:
// See MFCDragAndDropExample_20200213_1427.cpp for the implementation of this class
//

class CMFCDragAndDropExample202002131427App : public CWinApp
{
public:
	CMFCDragAndDropExample202002131427App() noexcept;


// Overrides
public:
	virtual BOOL InitInstance();
	virtual int ExitInstance();

// Implementation
	afx_msg void OnAppAbout();
	DECLARE_MESSAGE_MAP()
};

extern CMFCDragAndDropExample202002131427App theApp;
