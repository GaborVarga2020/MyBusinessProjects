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

// (Implemented by VargaG., on 2020.02.17.)
BOOL CMyOleDropTarget::IsFilePathNameListIsDragged(COleDataObject* a_pDataObject)
{
	// (Implemented by VargaG., on 2020.02.17.)
	m_droppedFilePathNames.RemoveAll();

	// (Implemented by VargaG., on 2020.02.17.)
	CLIPFORMAT clipFormat = CF_HDROP;
	HGLOBAL hglobalDropFiles = a_pDataObject->GetGlobalData(clipFormat);

	// (Implemented by VargaG., on 2020.02.17.)
	__try
	{
		// (Implemented by VargaG., on 2020.02.17.)
		LPDROPFILES pDropFiles = (LPDROPFILES)::GlobalLock(hglobalDropFiles);
		if (pDropFiles == NULL)
		{
			// (Implemented by VargaG., on 2020.02.17.)
			ASSERT(FALSE);
			return FALSE;
		}

		// (Implemented by VargaG., on 2020.02.17.)
		if (pDropFiles->fWide)
		{
			// (Implemented by VargaG., on 2020.02.17.)
			bool bAdditionalFileNameExistst = true;

			// (Implemented by VargaG., on 2020.02.17.)
			PWCHAR pDroppedFilePathAndName = (PWCHAR)((PCHAR)pDropFiles + pDropFiles->pFiles);

			do
			{
				// (Implemented by VargaG., on 2020.02.17.)
				m_droppedFilePathNames.Add(pDroppedFilePathAndName);

				// Get the number of characters in the string, not including the terminating null character.
				// (Implemented by VargaG., on 2020.02.17.)
				size_t nDroppedFilePathAndNameLengthWithoutTerminatingNullCharacter = wcsnlen_s(pDroppedFilePathAndName, MAX_PATH);

				// (Implemented by VargaG., on 2020.02.17.)
				pDroppedFilePathAndName = pDroppedFilePathAndName + nDroppedFilePathAndNameLengthWithoutTerminatingNullCharacter + 1;

				// (Implemented by VargaG., on 2020.02.17.)
				bAdditionalFileNameExistst = (*pDroppedFilePathAndName != L'\x0');
			}
			while (bAdditionalFileNameExistst);
		}
		else
		{
			// (Implemented by VargaG., on 2020.02.17.)
			TRACE("ANSI characters are not supported, only Unicode characters!");
			ASSERT(FALSE);
		}

		return TRUE;
	}
	__finally
	{
		// (Implemented by VargaG., on 2020.02.17.)
		BOOL bGlobalUnlockResult = ::GlobalUnlock(hglobalDropFiles);
		DWORD dwLastError = GetLastError();
		if ((bGlobalUnlockResult == FALSE) && (dwLastError != NO_ERROR))
		{
			// (Implemented by VargaG., on 2020.02.17.)
			ASSERT(FALSE);
			return FALSE;
		}
	}

	return FALSE;
}

// (Implemented by VargaG., on 2020.02.13.)
DROPEFFECT CMyOleDropTarget::OnDragEnter(CWnd* a_pWnd, COleDataObject* a_pDataObject, DWORD a_dwKeyState, CPoint a_point)
{
	// (Implemented by VargaG., on 2020.02.17.)
	DROPEFFECT dropEffect = DROPEFFECT_NONE;

	// (Implemented by VargaG., on 2020.02.17.)
	if (IsFilePathNameListIsDragged(a_pDataObject))
	{
		// (Implemented by VargaG., on 2020.02.17.)
		dropEffect = DROPEFFECT_COPY;
	}

	// (Implemented by VargaG., on 2020.02.17.)
	return dropEffect;
}

// (Implemented by VargaG., on 2020.02.17.)
DROPEFFECT CMyOleDropTarget::OnDragOver(CWnd* a_pWnd, COleDataObject* a_pDataObject, DWORD a_dwKeyState, CPoint a_point)
{
	// (Implemented by VargaG., on 2020.02.17.)
	DROPEFFECT dropEffect = DROPEFFECT_NONE;

	// (Implemented by VargaG., on 2020.02.17.)
	if (IsFilePathNameListIsDragged(a_pDataObject))
	{
		// (Implemented by VargaG., on 2020.02.17.)
		dropEffect = DROPEFFECT_COPY;
	}

	// (Implemented by VargaG., on 2020.02.17.)
	return dropEffect;
}

// (Implemented by VargaG., on 2020.02.13.)
BOOL CMyOleDropTarget::OnDrop(CWnd* a_pWnd, COleDataObject* a_pDataObject, DROPEFFECT a_dropEffect, CPoint a_point)
{
	// (Implemented by VargaG., on 2020.02.17.)
	BOOL bDropAllowed = IsFilePathNameListIsDragged(a_pDataObject);

	// (Implemented by VargaG., on 2020.02.17.)
	if (bDropAllowed)
	{
		// (Implemented by VargaG., on 2020.02.17.)
		TRACE("Number of files have been dropped: %d.\n", m_droppedFilePathNames.GetCount());

		// (Implemented by VargaG., on 2020.02.17.)
		for (int nDroppedFileDataIndex = 0; nDroppedFileDataIndex < m_droppedFilePathNames.GetCount(); nDroppedFileDataIndex++)
		{
			// (Implemented by VargaG., on 2020.02.17.)
			CString stringFileDataIndexed = m_droppedFilePathNames.GetAt(nDroppedFileDataIndex);
			TRACE(
				"Dropped file path and name (%d of %d): %s",
				nDroppedFileDataIndex + 1,
				m_droppedFilePathNames.GetCount(),
				stringFileDataIndexed
			);
		}
	}

	return bDropAllowed;
}
