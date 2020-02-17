#include "stdafx.h"		// (Implemented by VargaG., on 2020.02.13.)
#include "CMyOleDropTarget.h"		// (Implemented by VargaG., on 2020.02.13.)

// (Implemented by VargaG., on 2020.02.13.)
CMyOleDropTarget::~CMyOleDropTarget()
{
}

// (Implemented by VargaG., on 2020.02.13.)
CMyOleDropTarget::CMyOleDropTarget()
{
}

// (Implemented by VargaG., on 2020.02.13.)
DROPEFFECT CMyOleDropTarget::OnDragEnter(CWnd* a_pWnd, COleDataObject* a_pDataObject, DWORD a_dwKeyState, CPoint a_point)
{
/*
Possible return values.
(Implemented by VargaG., on 2020.02.17.)

	DROPEFFECT_NONE
	DROPEFFECT_COPY
	DROPEFFECT_MOVE
	DROPEFFECT_LINK
	DROPEFFECT_SCROLL
*/

	return DROPEFFECT_NONE;
}

// (Implemented by VargaG., on 2020.02.13.)
BOOL CMyOleDropTarget::OnDrop(CWnd* a_pWnd, COleDataObject* a_pDataObject, DROPEFFECT a_dropEffect, CPoint a_point)
{
	return TRUE;
}
