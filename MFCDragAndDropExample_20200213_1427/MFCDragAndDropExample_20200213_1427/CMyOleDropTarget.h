// Specifies that the compiler includes the header file only once, when compiling a source code file.
// The use of #pragma once can reduce build times, as the compiler won't open and read the file again after the first #include of the file in the translation unit.
// (Implemented by VargaG., on 2020.02.13.)
#pragma once

#include <afxole.h>		// (Implemented by VargaG., on 2020.02.13.)

// (Implemented by VargaG., on 2020.02.13.)
class CMyOleDropTarget : public COleDropTarget
{
private: CStringArray m_droppedFilePathNames;		// (Implemented by VargaG., on 2020.02.17.)

public: CMyOleDropTarget();		// (Implemented by VargaG., on 2020.02.13.)
public: virtual ~CMyOleDropTarget();		// (Implemented by VargaG., on 2020.02.13.)
public: BOOL IsFilePathNameListIsDragged(COleDataObject* a_pDataObject);		// (Implemented by VargaG., on 2020.02.17.)
public: virtual DROPEFFECT OnDragEnter(CWnd* a_pWnd, COleDataObject* a_pDataObject, DWORD a_dwKeyState, CPoint a_point);		// (Implemented by VargaG., on 2020.02.13.)
public: virtual DROPEFFECT OnDragOver(CWnd* a_pWnd, COleDataObject* a_pDataObject, DWORD a_dwKeyState, CPoint a_point);		// (Implemented by VargaG., on 2020.02.17.)
public: virtual BOOL OnDrop(CWnd* a_pWnd, COleDataObject* a_pDataObject, DROPEFFECT a_dropEffect, CPoint a_point);		// (Implemented by VargaG., on 2020.02.13.)
};

