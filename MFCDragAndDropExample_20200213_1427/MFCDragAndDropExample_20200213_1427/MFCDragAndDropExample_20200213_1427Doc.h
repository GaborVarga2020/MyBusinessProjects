
// MFCDragAndDropExample_20200213_1427Doc.h : interface of the CMFCDragAndDropExample202002131427Doc class
//


#pragma once


class CMFCDragAndDropExample202002131427Doc : public CDocument
{
protected: // create from serialization only
	CMFCDragAndDropExample202002131427Doc() noexcept;
	DECLARE_DYNCREATE(CMFCDragAndDropExample202002131427Doc)

// Attributes
public:

// Operations
public:

// Overrides
public:
	virtual BOOL OnNewDocument();
	virtual void Serialize(CArchive& ar);
#ifdef SHARED_HANDLERS
	virtual void InitializeSearchContent();
	virtual void OnDrawThumbnail(CDC& dc, LPRECT lprcBounds);
#endif // SHARED_HANDLERS

// Implementation
public:
	virtual ~CMFCDragAndDropExample202002131427Doc();
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif

protected:

// Generated message map functions
protected:
	DECLARE_MESSAGE_MAP()

#ifdef SHARED_HANDLERS
	// Helper function that sets search content for a Search Handler
	void SetSearchContent(const CString& value);
#endif // SHARED_HANDLERS
};
