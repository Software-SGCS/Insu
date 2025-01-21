<%@ Page CodeBehind="add1.aspx.vb" Language="vb" AutoEventWireup="false" Inherits="SgcsInvoice.add1" %>
/* [in] */ ULONG32 cSig, /* [size_is][in] */ unsigned char signature[ ]); 
HRESULT ( STDMETHODCALLTYPE *Abort )( ISymUnmanagedWriter * This); 
END_INTERFACE } ISymUnmanagedWriterVtbl; interface ISymUnmanagedWriter { 
CONST_VTBL struct ISymUnmanagedWriterVtbl *lpVtbl; }; #ifdef COBJMACROS #define 
ISymUnmanagedWriter_QueryInterface(This,riid,ppvObject) \ (This)-&gt;lpVtbl 
-&gt; QueryInterface(This,riid,ppvObject) #define 
ISymUnmanagedWriter_AddRef(This) \ (This)-&gt;lpVtbl -&gt; AddRef(This) #define 
ISymUnmanagedWriter_Release(This) \ (This)-&gt;lpVtbl -&gt; Release(This) 
#define 
ISymUnmanagedWriter_DefineDocument(This,url,language,languageVendor,documentType,pRetVal) 
\ (This)-&gt;lpVtbl -&gt; 
DefineDocument(This,url,language,languageVendor,documentType,pRetVal) #define 
ISymUnmanagedWriter_SetUserEntryPoint(This,entryMethod) \ (This)-&gt;lpVtbl 
-&gt; SetUserEntryPoint(This,entryMethod) #define 
ISymUnmanagedWriter_OpenMethod(This,method) \ (This)-&gt;lpVtbl -&gt; 
OpenMethod(This,method) #define ISymUnmanagedWriter_CloseMethod(This) \ 
(This)-&gt;lpVtbl -&gt; CloseMethod(This) #define 
ISymUnmanagedWriter_OpenScope(This,startOffset,pRetVal) \ (This)-&gt;lpVtbl 
-&gt; OpenScope(This,startOffset,pRetVal) #define 
ISymUnmanagedWriter_CloseScope(This,endOffset) \ (This)-&gt;lpVtbl -&gt; 
CloseScope(This,endOffset) #define 
ISymUnmanagedWriter_SetScopeRange(This,scopeID,startOffset,endOffset) \ 
(This)-&gt;lpVtbl -&gt; SetScopeRange(This,scopeID,startOffset,endOffset) 
#define 
ISymUnmanagedWriter_DefineLocalVariable(This,name,attributes,cSig,signature,addrKind,addr1,addr2,addr3,startOffset,endOffset) 
\ (This)-&gt;lpVtbl -&gt; 
DefineLocalVariable(This,name,attributes,cSig,signature,addrKind,addr1,addr2,addr3,startOffset,endOffset) 
#define 
ISymUnmanagedWriter_DefineParameter(This,name,attributes,sequence,addrKind,addr1,addr2,addr3) 
\ (This)-&gt;lpVtbl -&gt; 
DefineParameter(This,name,attributes,sequence,addrKind,addr1,addr2,addr3) 
#define 
ISymUnmanagedWriter_DefineField(This,parent,name,attributes,cSig,signature,addrKind,addr1,addr2,addr3) 
\ (This)-&gt;lpVtbl -&gt; 
DefineField(This,parent,name,attributes,cSig,signature,addrKind,addr1,addr2,addr3) 
#define 
ISymUnmanagedWriter_DefineGlobalVariable(This,name,attributes,cSig,signature,addrKind,addr1,addr2,addr3) 
\ (This)-&gt;lpVtbl -&gt; 
DefineGlobalVariable(This,name,attributes,cSig,signature,addrKind,addr1,addr2,addr3) 
#define ISymUnmanagedWriter_Close(This) \ (This)-&gt;lpVtbl -&gt; Close(This) 
#define ISymUnmanagedWriter_SetSymAttribute(This,parent,name,cData,data) \ 
(This)-&gt;lpVtbl -&gt; SetSymAttribute(This,parent,name,cData,data) #define 
ISymUnmanagedWriter_OpenNamespace(This,name) \ (This)-&gt;lpVtbl -&gt; 
OpenNamespace(This,name) #define ISymUnmanagedWriter_CloseNamespace(This) \ 
(This)-&gt;lpVtbl -&gt; CloseNamespace(This) #define 
ISymUnmanagedWriter_UsingNamespace(This,fullName) \ (This)-&gt;lpVtbl -&gt; 
UsingNamespace(This,fullName) #define 
ISymUnmanagedWriter_SetMethodSourceRange(This,startDoc,startLine,startColumn,endDoc,endLine,endColumn) 
\ (This)-&gt;lpVtbl -&gt; 
SetMethodSourceRange(This,startDoc,startLine,startColumn,endDoc,endLine,endColumn) 
#define 
ISymUnmanagedWriter_Initialize(This,emitter,filename,pIStream,fFullBuild) \ 
(This)-&gt;lpVtbl -&gt; Initialize(This,emitter,filename,pIStream,fFullBuild) 
#define ISymUnmanagedWriter_GetDebugInfo(This,pIDD,cData,pcData,data) \ 
(This)-&gt;lpVtbl -&gt; GetDebugInfo(This,pIDD,cData,pcData,data) #define 
ISymUnmanagedWriter_DefineSequencePoints(This,document,spCount,offsets,lines,columns,endLines,endColumns) 
\ (This)-&gt;lpVtbl -&gt; 
DefineSequencePoints(This,document,spCount,offsets,lines,columns,endLines,endColumns) 
#define ISymUnmanagedWriter_RemapToken(This,oldToken,newToken) \ 
(This)-&gt;lpVtbl -&gt; RemapToken(This,oldToken,newToken) #define 
ISymUnmanagedWriter_Initialize2(This,emitter,tempfilename,pIStream,fFullBuild,finalfilename) 
\ (This)-&gt;lpVtbl -&gt; Initialize2(This,em
