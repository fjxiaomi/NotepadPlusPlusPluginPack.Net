﻿// NPP plugin platform for .Net v0.92.83 by Kasper B. Graversen etc.
//
// This file should stay in sync with the CPP project file
// "notepad-plus-plus/PowerEditor/src/MISC/PluginsManager/Notepad_plus_msgs.h"
// found at
// https://github.com/notepad-plus-plus/notepad-plus-plus/blob/master/PowerEditor/src/MISC/PluginsManager/Notepad_plus_msgs.h

using System;

namespace Kbg.NppPluginNET.PluginInfrastructure
{
    class Constants
    {
        public const int WM_USER = 0x400;
        public const int NPPMSG = WM_USER + 1000;
    }

    public enum LangType
    {
        L_TEXT, L_PHP, L_C, L_CPP, L_CS, L_OBJC, L_JAVA, L_RC,
        L_HTML, L_XML, L_MAKEFILE, L_PASCAL, L_BATCH, L_INI, L_ASCII, L_USER,
        L_ASP, L_SQL, L_VB, L_JS, L_CSS, L_PERL, L_PYTHON, L_LUA,
        L_TEX, L_FORTRAN, L_BASH, L_FLASH, L_NSIS, L_TCL, L_LISP, L_SCHEME,
        L_ASM, L_DIFF, L_PROPS, L_PS, L_RUBY, L_SMALLTALK, L_VHDL, L_KIX, L_AU3,
        L_CAML, L_ADA, L_VERILOG, L_MATLAB, L_HASKELL, L_INNO, L_SEARCHRESULT,
        L_CMAKE, L_YAML, L_COBOL, L_GUI4CLI, L_D, L_POWERSHELL, L_R, L_JSP,
        L_COFFEESCRIPT, L_JSON, L_JAVASCRIPT, L_FORTRAN_77,
        // Don't use L_JS, use L_JAVASCRIPT instead
        // The end of enumated language type, so it should be always at the end
        L_EXTERNAL
    }

    [Flags]
    public enum NppMsg : uint
    {
        /* ++Autogenerated -- start of section automatically generated from notepad-plus-plus\PowerEditor\src\MISC\PluginsManager\Notepad_plus_msgs.h */

        NPPMSG = Constants.WM_USER + 1000,

        NPPM_GETCURRENTSCINTILLA = Constants.NPPMSG + 4,
        NPPM_GETCURRENTLANGTYPE = Constants.NPPMSG + 5,
        NPPM_SETCURRENTLANGTYPE = Constants.NPPMSG + 6,

        NPPM_GETNBOPENFILES = Constants.NPPMSG + 7,
        ALL_OPEN_FILES = 0,
        PRIMARY_VIEW = 1,
        SECOND_VIEW = 2,

        NPPM_GETOPENFILENAMES = Constants.NPPMSG + 8,

        NPPM_MODELESSDIALOG = Constants.NPPMSG + 12,
        MODELESSDIALOGADD = 0,
        MODELESSDIALOGREMOVE = 1,

        NPPM_GETNBSESSIONFILES = Constants.NPPMSG + 13,
        NPPM_GETSESSIONFILES = Constants.NPPMSG + 14,
        NPPM_SAVESESSION = Constants.NPPMSG + 15,
        NPPM_SAVECURRENTSESSION = Constants.NPPMSG + 16,

        NPPM_GETOPENFILENAMESPRIMARY = Constants.NPPMSG + 17,
        NPPM_GETOPENFILENAMESSECOND = Constants.NPPMSG + 18,

        NPPM_CREATESCINTILLAHANDLE = Constants.NPPMSG + 20,
        NPPM_DESTROYSCINTILLAHANDLE = Constants.NPPMSG + 21,
        NPPM_GETNBUSERLANG = Constants.NPPMSG + 22,

        NPPM_GETCURRENTDOCINDEX = Constants.NPPMSG + 23,
        MAIN_VIEW = 0,
        SUB_VIEW = 1,

        NPPM_SETSTATUSBAR = Constants.NPPMSG + 24,
        STATUSBAR_DOC_TYPE = 0,
        STATUSBAR_DOC_SIZE = 1,
        STATUSBAR_CUR_POS = 2,
        STATUSBAR_EOF_FORMAT = 3,
        STATUSBAR_UNICODE_TYPE = 4,
        STATUSBAR_TYPING_MODE = 5,

        NPPM_GETMENUHANDLE = Constants.NPPMSG + 25,
        NPPPLUGINMENU = 0,
        /// <summary>
        /// INT NPPM_GETMENUHANDLE(INT menuChoice, 0)
        /// Return: menu handle (HMENU) of choice (plugin menu handle or Notepad++ main menu handle)
        /// </summary>
        NPPMAINMENU = 1,

        /// <summary>
        ///ascii file to unicode
        ///int NPPM_ENCODESCI(MAIN_VIEW/SUB_VIEW, 0)
        ///return new unicodeMode
        /// </summary>
        NPPM_ENCODESCI = Constants.NPPMSG + 26,

        /// <summary>
        ///unicode file to ascii
        ///int NPPM_DECODESCI(MAIN_VIEW/SUB_VIEW, 0)
        ///return old unicodeMode
        /// </summary>
        NPPM_DECODESCI = Constants.NPPMSG + 27,

        /// <summary>
        ///void NPPM_ACTIVATEDOC(int view, int index2Activate)
        /// </summary>
        NPPM_ACTIVATEDOC = Constants.NPPMSG + 28,

        /// <summary>
        ///void NPPM_LAUNCHFINDINFILESDLG(TCHAR * dir2Search, TCHAR * filtre)
        /// </summary>
        NPPM_LAUNCHFINDINFILESDLG = Constants.NPPMSG + 29,

        /// <summary>
        ///void NPPM_DMMSHOW(0, tTbData->hClient)
        /// </summary>
        NPPM_DMMSHOW = Constants.NPPMSG + 30,

        /// <summary>
        ///void NPPM_DMMHIDE(0, tTbData->hClient)
        /// </summary>
        NPPM_DMMHIDE = Constants.NPPMSG + 31,

        /// <summary>
        ///void NPPM_DMMUPDATEDISPINFO(0, tTbData->hClient)
        /// </summary>
        NPPM_DMMUPDATEDISPINFO = Constants.NPPMSG + 32,

        /// <summary>
        ///void NPPM_DMMREGASDCKDLG(0, &tTbData)
        /// </summary>
        NPPM_DMMREGASDCKDLG = Constants.NPPMSG + 33,

        /// <summary>
        ///void NPPM_LOADSESSION(0, const TCHAR* file name)
        /// </summary>
        NPPM_LOADSESSION = Constants.NPPMSG + 34,

        /// <summary>
        ///void WM_DMM_VIEWOTHERTAB(0, tTbData->pszName)
        /// </summary>
        NPPM_DMMVIEWOTHERTAB = Constants.NPPMSG + 35,

        /// <summary>
        ///BOOL NPPM_RELOADFILE(BOOL withAlert, TCHAR *filePathName2Reload)
        /// </summary>
        NPPM_RELOADFILE = Constants.NPPMSG + 36,

        /// <summary>
        ///BOOL NPPM_SWITCHTOFILE(0, TCHAR *filePathName2switch)
        /// </summary>
        NPPM_SWITCHTOFILE = Constants.NPPMSG + 37,

        /// <summary>
        ///BOOL NPPM_SAVECURRENTFILE(0, 0)
        /// </summary>
        NPPM_SAVECURRENTFILE = Constants.NPPMSG + 38,

        /// <summary>
        ///BOOL NPPM_SAVEALLFILES(0, 0)
        /// </summary>
        NPPM_SAVEALLFILES = Constants.NPPMSG + 39,

        /// <summary>
        ///void WM_PIMENU_CHECK(UINT	funcItem[X]._cmdID, TRUE/FALSE)
        /// </summary>
        NPPM_SETMENUITEMCHECK = Constants.NPPMSG + 40,

        /// <summary>
        ///void WM_ADDTOOLBARICON(UINT funcItem[X]._cmdID, toolbarIcons icon)
        /// </summary>
        NPPM_ADDTOOLBARICON = Constants.NPPMSG + 41,

        /// <summary>
        ///winVer NPPM_GETWINDOWSVERSION(0, 0)
        /// </summary>
        NPPM_GETWINDOWSVERSION = Constants.NPPMSG + 42,

        /// <summary>
        ///HWND WM_DMM_GETPLUGINHWNDBYNAME(const TCHAR *windowName, const TCHAR *moduleName)
        /// if moduleName is NULL, then return value is NULL
        /// if windowName is NULL, then the first found window handle which matches with the moduleName will be returned
        /// </summary>
        NPPM_DMMGETPLUGINHWNDBYNAME = Constants.NPPMSG + 43,

        /// <summary>
        ///BOOL NPPM_MAKECURRENTBUFFERDIRTY(0, 0)
        /// </summary>
        NPPM_MAKECURRENTBUFFERDIRTY = Constants.NPPMSG + 44,

        /// <summary>
        ///BOOL NPPM_GETENABLETHEMETEXTUREFUNC(0, 0)
        /// </summary>
        NPPM_GETENABLETHEMETEXTUREFUNC = Constants.NPPMSG + 45,

        /// <summary>
        ///void NPPM_GETPLUGINSCONFIGDIR(int strLen, TCHAR *str)
        /// </summary>
        NPPM_GETPLUGINSCONFIGDIR = Constants.NPPMSG + 46,

        /// <summary>
        ///BOOL NPPM_MSGTOPLUGIN(TCHAR *destModuleName, CommunicationInfo *info)
        /// return value is TRUE when the message arrive to the destination plugins.
        /// if destModule or info is NULL, then return value is FALSE
        /// </summary>
        NPPM_MSGTOPLUGIN = Constants.NPPMSG + 47,

        /// <summary>
        ///void NPPM_MENUCOMMAND(0, int cmdID)
        /// uncomment //#include "menuCmdID.h"
        /// in the beginning of this file then use the command symbols defined in "menuCmdID.h" file
        /// to access all the Notepad++ menu command items
        /// </summary>
        NPPM_MENUCOMMAND = Constants.NPPMSG + 48,

        /// <summary>
        ///void NPPM_TRIGGERTABBARCONTEXTMENU(int view, int index2Activate)
        /// </summary>
        NPPM_TRIGGERTABBARCONTEXTMENU = Constants.NPPMSG + 49,

        /// <summary>
        /// int NPPM_GETNPPVERSION(0, 0)
        /// return version
        /// ex : v4.6
        /// HIWORD(version) == 4
        /// LOWORD(version) == 6
        /// </summary>
        NPPM_GETNPPVERSION = Constants.NPPMSG + 50,

        /// <summary>
        /// BOOL NPPM_HIDETABBAR(0, BOOL hideOrNot)
        /// if hideOrNot is set as TRUE then tab bar will be hidden
        /// otherwise it'll be shown.
        /// return value : the old status value
        /// </summary>
        NPPM_HIDETABBAR = Constants.NPPMSG + 51,

        /// <summary>
        /// BOOL NPPM_ISTABBARHIDDEN(0, 0)
        /// returned value : TRUE if tab bar is hidden, otherwise FALSE
        /// </summary>
        NPPM_ISTABBARHIDDEN = Constants.NPPMSG + 52,

        /// <summary>
        /// INT NPPM_GETPOSFROMBUFFERID(INT bufferID, INT priorityView)
        /// Return VIEW|INDEX from a buffer ID. -1 if the bufferID non existing
        /// if priorityView set to SUB_VIEW, then SUB_VIEW will be search firstly
        ///
        /// VIEW takes 2 highest bits and INDEX (0 based) takes the rest (30 bits)
        /// Here's the values for the view :
        ///  MAIN_VIEW 0
        ///  SUB_VIEW  1
        /// </summary>
        NPPM_GETPOSFROMBUFFERID = Constants.NPPMSG + 57,

        /// <summary>
        /// INT NPPM_GETFULLPATHFROMBUFFERID(INT bufferID, TCHAR *fullFilePath)
        /// Get full path file name from a bufferID.
        /// Return -1 if the bufferID non existing, otherwise the number of TCHAR copied/to copy
        /// User should call it with fullFilePath be NULL to get the number of TCHAR (not including the nul character),
        /// allocate fullFilePath with the return values + 1, then call it again to get  full path file name
        /// </summary>
        NPPM_GETFULLPATHFROMBUFFERID = Constants.NPPMSG + 58,

        /// <summary>
        /// LRESULT NPPM_GETBUFFERIDFROMPOS(INT index, INT iView)
        /// wParam: Position of document
        /// lParam: View to use, 0 = Main, 1 = Secondary
        /// Returns 0 if invalid
        /// </summary>
        NPPM_GETBUFFERIDFROMPOS = Constants.NPPMSG + 59,

        /// <summary>
        /// LRESULT NPPM_GETCURRENTBUFFERID(0, 0)
        /// Returns active Buffer
        /// </summary>
        NPPM_GETCURRENTBUFFERID = Constants.NPPMSG + 60,

        /// <summary>
        /// VOID NPPM_RELOADBUFFERID(0, 0)
        /// Reloads Buffer
        /// wParam: Buffer to reload
        /// lParam: 0 if no alert, else alert
        /// </summary>
        NPPM_RELOADBUFFERID = Constants.NPPMSG + 61,

        /// <summary>
        /// INT NPPM_GETBUFFERLANGTYPE(INT bufferID, 0)
        /// wParam: BufferID to get LangType from
        /// lParam: 0
        /// Returns as int, see LangType. -1 on error
        /// </summary>
        NPPM_GETBUFFERLANGTYPE = Constants.NPPMSG + 64,

        /// <summary>
        /// BOOL NPPM_SETBUFFERLANGTYPE(INT bufferID, INT langType)
        /// wParam: BufferID to set LangType of
        /// lParam: LangType
        /// Returns TRUE on success, FALSE otherwise
        /// use int, see LangType for possible values
        /// L_USER and L_EXTERNAL are not supported
        /// </summary>
        NPPM_SETBUFFERLANGTYPE = Constants.NPPMSG + 65,

        /// <summary>
        /// INT NPPM_GETBUFFERENCODING(INT bufferID, 0)
        /// wParam: BufferID to get encoding from
        /// lParam: 0
        /// returns as int, see UniMode. -1 on error
        /// </summary>
        NPPM_GETBUFFERENCODING = Constants.NPPMSG + 66,

        /// <summary>
        /// BOOL NPPM_SETBUFFERENCODING(INT bufferID, INT encoding)
        /// wParam: BufferID to set encoding of
        /// lParam: encoding
        /// Returns TRUE on success, FALSE otherwise
        /// use int, see UniMode
        /// Can only be done on new, unedited files
        /// </summary>
        NPPM_SETBUFFERENCODING = Constants.NPPMSG + 67,

        /// <summary>
        /// INT NPPM_GETBUFFERFORMAT(INT bufferID, 0)
        /// wParam: BufferID to get format from
        /// lParam: 0
        /// returns as int, see formatType. -1 on error
        /// </summary>
        NPPM_GETBUFFERFORMAT = Constants.NPPMSG + 68,

        /// <summary>
        /// BOOL NPPM_SETBUFFERFORMAT(INT bufferID, INT format)
        /// wParam: BufferID to set format of
        /// lParam: format
        /// Returns TRUE on success, FALSE otherwise
        /// use int, see formatType
        /// </summary>
        NPPM_SETBUFFERFORMAT = Constants.NPPMSG + 69,

        /// <summary>
        /// BOOL NPPM_ADDREBAR(0, REBARBANDINFO *)
        /// Returns assigned ID in wID value of struct pointer
        /// </summary>
        NPPM_ADDREBAR = Constants.NPPMSG + 57,

        /// <summary>
        /// BOOL NPPM_ADDREBAR(INT ID, REBARBANDINFO *)
        ///Use ID assigned with NPPM_ADDREBAR
        /// </summary>
        NPPM_UPDATEREBAR = Constants.NPPMSG + 58,

        /// <summary>
        /// BOOL NPPM_ADDREBAR(INT ID, 0)
        ///Use ID assigned with NPPM_ADDREBAR
        /// </summary>
        NPPM_REMOVEREBAR = Constants.NPPMSG + 59,

        /// <summary>
        /// BOOL NPPM_HIDETOOLBAR(0, BOOL hideOrNot)
        /// if hideOrNot is set as TRUE then tool bar will be hidden
        /// otherwise it'll be shown.
        /// return value : the old status value
        /// </summary>
        NPPM_HIDETOOLBAR = Constants.NPPMSG + 70,

        /// <summary>
        /// BOOL NPPM_ISTOOLBARHIDDEN(0, 0)
        /// returned value : TRUE if tool bar is hidden, otherwise FALSE
        /// </summary>
        NPPM_ISTOOLBARHIDDEN = Constants.NPPMSG + 71,

        /// <summary>
        /// BOOL NPPM_HIDEMENU(0, BOOL hideOrNot)
        /// if hideOrNot is set as TRUE then menu will be hidden
        /// otherwise it'll be shown.
        /// return value : the old status value
        /// </summary>
        NPPM_HIDEMENU = Constants.NPPMSG + 72,

        /// <summary>
        /// BOOL NPPM_ISMENUHIDDEN(0, 0)
        /// returned value : TRUE if menu is hidden, otherwise FALSE
        /// </summary>
        NPPM_ISMENUHIDDEN = Constants.NPPMSG + 73,

        /// <summary>
        /// BOOL NPPM_HIDESTATUSBAR(0, BOOL hideOrNot)
        /// if hideOrNot is set as TRUE then STATUSBAR will be hidden
        /// otherwise it'll be shown.
        /// return value : the old status value
        /// </summary>
        NPPM_HIDESTATUSBAR = Constants.NPPMSG + 74,

        /// <summary>
        /// BOOL NPPM_ISSTATUSBARHIDDEN(0, 0)
        /// returned value : TRUE if STATUSBAR is hidden, otherwise FALSE
        /// </summary>
        NPPM_ISSTATUSBARHIDDEN = Constants.NPPMSG + 75,

        /// <summary>
        /// BOOL NPPM_GETSHORTCUTBYCMDID(int cmdID, ShortcutKey *sk)
        /// get your plugin command current mapped shortcut into sk via cmdID
        /// You may need it after getting NPPN_READY notification
        /// returned value : TRUE if this function call is successful and shorcut is enable, otherwise FALSE
        /// </summary>
        NPPM_GETSHORTCUTBYCMDID = Constants.NPPMSG + 76,

        /// <summary>
        /// BOOL NPPM_DOOPEN(0, const TCHAR *fullPathName2Open)
        /// fullPathName2Open indicates the full file path name to be opened.
        /// The return value is TRUE (1) if the operation is successful, otherwise FALSE (0).
        /// </summary>
        NPPM_DOOPEN = Constants.NPPMSG + 77,

        /// <summary>
        /// BOOL NPPM_SAVECURRENTFILEAS (BOOL asCopy, const TCHAR* filename)
        /// </summary>
        NPPM_SAVECURRENTFILEAS = Constants.NPPMSG + 78,

        /// <summary>
        /// INT NPPM_GETCURRENTNATIVELANGENCODING(0, 0)
        /// returned value : the current native language enconding
        /// </summary>
        NPPM_GETCURRENTNATIVELANGENCODING = Constants.NPPMSG + 79,

        /// <summary>
        /// returns TRUE if NPPM_ALLOCATECMDID is supported
        /// Use to identify if subclassing is necessary
        /// </summary>
        NPPM_ALLOCATESUPPORTED = Constants.NPPMSG + 80,

        /// <summary>
        /// BOOL NPPM_ALLOCATECMDID(int numberRequested, int* startNumber)
        /// sets startNumber to the initial command ID if successful
        /// Returns: TRUE if successful, FALSE otherwise. startNumber will also be set to 0 if unsuccessful
        /// </summary>
        NPPM_ALLOCATECMDID = Constants.NPPMSG + 81,

        /// <summary>
        /// BOOL NPPM_ALLOCATEMARKER(int numberRequested, int* startNumber)
        /// sets startNumber to the initial command ID if successful
        /// Allocates a marker number to a plugin
        /// Returns: TRUE if successful, FALSE otherwise. startNumber will also be set to 0 if unsuccessful
        /// </summary>
        NPPM_ALLOCATEMARKER = Constants.NPPMSG + 82,

        /// <summary>
        /// INT NPPM_GETLANGUAGENAME(int langType, TCHAR *langName)
        /// Get programing language name from the given language type (LangType)
        /// Return value is the number of copied character / number of character to copy (\0 is not included)
        /// You should call this function 2 times - the first time you pass langName as NULL to get the number of characters to copy.
        /// You allocate a buffer of the length of (the number of characters + 1) then call NPPM_GETLANGUAGENAME function the 2nd time
        /// by passing allocated buffer as argument langName
        /// </summary>
        NPPM_GETLANGUAGENAME = Constants.NPPMSG + 83,

        /// <summary>
        /// INT NPPM_GETLANGUAGEDESC(int langType, TCHAR *langDesc)
        /// Get programing language short description from the given language type (LangType)
        /// Return value is the number of copied character / number of character to copy (\0 is not included)
        /// You should call this function 2 times - the first time you pass langDesc as NULL to get the number of characters to copy.
        /// You allocate a buffer of the length of (the number of characters + 1) then call NPPM_GETLANGUAGEDESC function the 2nd time
        /// by passing allocated buffer as argument langDesc
        /// </summary>
        NPPM_GETLANGUAGEDESC = Constants.NPPMSG + 84,

        /// <summary>
        /// VOID NPPM_ISDOCSWITCHERSHOWN(0, BOOL toShowOrNot)
        /// Send this message to show or hide doc switcher.
        /// if toShowOrNot is TRUE then show doc switcher, otherwise hide it.
        /// </summary>
        NPPM_SHOWDOCSWITCHER = Constants.NPPMSG + 85,

        /// <summary>
        /// BOOL NPPM_ISDOCSWITCHERSHOWN(0, 0)
        /// Check to see if doc switcher is shown.
        /// </summary>
        NPPM_ISDOCSWITCHERSHOWN = Constants.NPPMSG + 86,

        /// <summary>
        /// BOOL NPPM_GETAPPDATAPLUGINSALLOWED(0, 0)
        /// Check to see if loading plugins from "%APPDATA%\Notepad++\plugins" is allowed.
        /// </summary>
        NPPM_GETAPPDATAPLUGINSALLOWED = Constants.NPPMSG + 87,

        /// <summary>
        /// INT NPPM_GETCURRENTVIEW(0, 0)
        /// Return: current edit view of Notepad++. Only 2 possible values: 0 = Main, 1 = Secondary
        /// </summary>
        NPPM_GETCURRENTVIEW = Constants.NPPMSG + 88,

        /// <summary>
        /// VOID NPPM_DOCSWITCHERDISABLECOLUMN(0, BOOL disableOrNot)
        /// Disable or enable extension column of doc switcher
        /// </summary>
        NPPM_DOCSWITCHERDISABLECOLUMN = Constants.NPPMSG + 89,

        /// <summary>
        /// INT NPPM_GETEDITORDEFAULTFOREGROUNDCOLOR(0, 0)
        /// Return: current editor default foreground color. You should convert the returned value in COLORREF
        /// </summary>
        NPPM_GETEDITORDEFAULTFOREGROUNDCOLOR = Constants.NPPMSG + 90,

        /// <summary>
        /// INT NPPM_GETEDITORDEFAULTBACKGROUNDCOLOR(0, 0)
        /// Return: current editor default background color. You should convert the returned value in COLORREF
        /// </summary>
        NPPM_GETEDITORDEFAULTBACKGROUNDCOLOR = Constants.NPPMSG + 91,

        /// <summary>
        /// VOID NPPM_SETSMOOTHFONT(0, BOOL setSmoothFontOrNot)
        /// </summary>
        NPPM_SETSMOOTHFONT = Constants.NPPMSG + 92,

        /// <summary>
        /// VOID NPPM_SETEDITORBORDEREDGE(0, BOOL withEditorBorderEdgeOrNot)
        /// </summary>
        NPPM_SETEDITORBORDEREDGE = Constants.NPPMSG + 93,

        /// <summary>
        /// VOID NPPM_SAVEFILE(0, const TCHAR *fileNameToSave)
        /// </summary>
        NPPM_SAVEFILE = Constants.NPPMSG + 94,

        RUNCOMMAND_USER = Constants.WM_USER + 3000,
        NPPM_GETFULLCURRENTPATH = RUNCOMMAND_USER + FULL_CURRENT_PATH,
        NPPM_GETCURRENTDIRECTORY = RUNCOMMAND_USER + CURRENT_DIRECTORY,
        NPPM_GETFILENAME = RUNCOMMAND_USER + FILE_NAME,
        NPPM_GETNAMEPART = RUNCOMMAND_USER + NAME_PART,
        NPPM_GETEXTPART = RUNCOMMAND_USER + EXT_PART,
        NPPM_GETCURRENTWORD = RUNCOMMAND_USER + CURRENT_WORD,
        /// <summary>
        /// BOOL NPPM_GETXXXXXXXXXXXXXXXX(size_t strLen, TCHAR *str)
        /// where str is the allocated TCHAR array,
        ///	     strLen is the allocated array size
        /// The return value is TRUE when get generic_string operation success
        /// Otherwise (allocated array size is too small) FALSE
        /// </summary>
        NPPM_GETNPPDIRECTORY = RUNCOMMAND_USER + NPP_DIRECTORY,

        /// <summary>
        /// INT NPPM_GETCURRENTLINE(0, 0)
        /// return the caret current position line
        /// </summary>
        NPPM_GETCURRENTLINE = RUNCOMMAND_USER + CURRENT_LINE,

        /// <summary>
        /// INT NPPM_GETCURRENTCOLUMN(0, 0)
        /// return the caret current position column
        /// </summary>
        NPPM_GETCURRENTCOLUMN = RUNCOMMAND_USER + CURRENT_COLUMN,

        VAR_NOT_RECOGNIZED = 0,
        FULL_CURRENT_PATH = 1,
        CURRENT_DIRECTORY = 2,
        FILE_NAME = 3,
        NAME_PART = 4,
        EXT_PART = 5,
        CURRENT_WORD = 6,
        NPP_DIRECTORY = 7,
        CURRENT_LINE = 8,
        CURRENT_COLUMN = 9,

        /// <summary>
        /// To notify plugins that all the procedures of launchment of notepad++ are done.
        ///scnNotification->nmhdr.code = NPPN_READY;
        ///scnNotification->nmhdr.hwndFrom = hwndNpp;
        ///scnNotification->nmhdr.idFrom = 0;
        /// </summary>
        NPPN_FIRST = 1000,
        /// <summary>
        ///scnNotification->nmhdr.code = NPPN_READY;
        ///scnNotification->nmhdr.hwndFrom = hwndNpp;
        ///scnNotification->nmhdr.idFrom = 0;
        /// </summary>
        NPPN_READY = NPPN_FIRST + 1,

        /// <summary>
        ///scnNotification->nmhdr.code = NPPN_TB_MODIFICATION;
        ///scnNotification->nmhdr.hwndFrom = hwndNpp;
        ///scnNotification->nmhdr.idFrom = 0;
        /// </summary>
        NPPN_TBMODIFICATION = NPPN_FIRST + 2,

        /// <summary>
        ///scnNotification->nmhdr.code = NPPN_FILEBEFORECLOSE;
        ///scnNotification->nmhdr.hwndFrom = hwndNpp;
        ///scnNotification->nmhdr.idFrom = BufferID;
        /// </summary>
        NPPN_FILEBEFORECLOSE = NPPN_FIRST + 3,

        /// <summary>
        ///scnNotification->nmhdr.code = NPPN_FILEOPENED;
        ///scnNotification->nmhdr.hwndFrom = hwndNpp;
        ///scnNotification->nmhdr.idFrom = BufferID;
        /// </summary>
        NPPN_FILEOPENED = NPPN_FIRST + 4,

        /// <summary>
        ///scnNotification->nmhdr.code = NPPN_FILECLOSED;
        ///scnNotification->nmhdr.hwndFrom = hwndNpp;
        ///scnNotification->nmhdr.idFrom = BufferID;
        /// </summary>
        NPPN_FILECLOSED = NPPN_FIRST + 5,

        /// <summary>
        ///scnNotification->nmhdr.code = NPPN_FILEBEFOREOPEN;
        ///scnNotification->nmhdr.hwndFrom = hwndNpp;
        ///scnNotification->nmhdr.idFrom = BufferID;
        /// </summary>
        NPPN_FILEBEFOREOPEN = NPPN_FIRST + 6,

        /// <summary>
        ///scnNotification->nmhdr.code = NPPN_FILEBEFOREOPEN;
        ///scnNotification->nmhdr.hwndFrom = hwndNpp;
        ///scnNotification->nmhdr.idFrom = BufferID;
        /// </summary>
        NPPN_FILEBEFORESAVE = NPPN_FIRST + 7,

        /// <summary>
        ///scnNotification->nmhdr.code = NPPN_FILESAVED;
        ///scnNotification->nmhdr.hwndFrom = hwndNpp;
        ///scnNotification->nmhdr.idFrom = BufferID;
        /// </summary>
        NPPN_FILESAVED = NPPN_FIRST + 8,

        /// <summary>
        ///scnNotification->nmhdr.code = NPPN_SHUTDOWN;
        ///scnNotification->nmhdr.hwndFrom = hwndNpp;
        ///scnNotification->nmhdr.idFrom = 0;
        /// </summary>
        NPPN_SHUTDOWN = NPPN_FIRST + 9,

        /// <summary>
        ///scnNotification->nmhdr.code = NPPN_BUFFERACTIVATED;
        ///scnNotification->nmhdr.hwndFrom = hwndNpp;
        ///scnNotification->nmhdr.idFrom = activatedBufferID;
        /// </summary>
        NPPN_BUFFERACTIVATED = NPPN_FIRST + 10,

        /// <summary>
        ///scnNotification->nmhdr.code = NPPN_LANGCHANGED;
        ///scnNotification->nmhdr.hwndFrom = hwndNpp;
        ///scnNotification->nmhdr.idFrom = currentBufferID;
        /// </summary>
        NPPN_LANGCHANGED = NPPN_FIRST + 11,

        /// <summary>
        ///scnNotification->nmhdr.code = NPPN_WORDSTYLESUPDATED;
        ///scnNotification->nmhdr.hwndFrom = hwndNpp;
        ///scnNotification->nmhdr.idFrom = currentBufferID;
        /// </summary>
        NPPN_WORDSTYLESUPDATED = NPPN_FIRST + 12,

        /// <summary>
        ///scnNotification->nmhdr.code = NPPN_SHORTCUTSREMAPPED;
        ///scnNotification->nmhdr.hwndFrom = ShortcutKeyStructurePointer;
        ///scnNotification->nmhdr.idFrom = cmdID;
        ///where ShortcutKeyStructurePointer is pointer of struct ShortcutKey:
        ///struct ShortcutKey {
        ///	bool _isCtrl;
        ///	bool _isAlt;
        ///	bool _isShift;
        ///	UCHAR _key;
        ///};
        /// </summary>
        NPPN_SHORTCUTREMAPPED = NPPN_FIRST + 13,

        /// <summary>
        ///scnNotification->nmhdr.code = NPPN_FILEBEFOREOPEN;
        ///scnNotification->nmhdr.hwndFrom = hwndNpp;
        ///scnNotification->nmhdr.idFrom = NULL;
        /// </summary>
        NPPN_FILEBEFORELOAD = NPPN_FIRST + 14,

        /// <summary>
        ///scnNotification->nmhdr.code = NPPN_FILEOPENFAILED;
        ///scnNotification->nmhdr.hwndFrom = hwndNpp;
        ///scnNotification->nmhdr.idFrom = BufferID;
        /// </summary>
        NPPN_FILELOADFAILED = NPPN_FIRST + 15,

        /// <summary>
        ///scnNotification->nmhdr.code = NPPN_READONLYCHANGED;
        ///scnNotification->nmhdr.hwndFrom = bufferID;
        ///scnNotification->nmhdr.idFrom = docStatus;
        /// where bufferID is BufferID
        ///       docStatus can be combined by DOCSTAUS_READONLY and DOCSTAUS_BUFFERDIRTY
        /// </summary>
        NPPN_READONLYCHANGED = NPPN_FIRST + 16,

        DOCSTAUS_READONLY = 1,
        DOCSTAUS_BUFFERDIRTY = 2,

        /// <summary>
        ///scnNotification->nmhdr.code = NPPN_DOCORDERCHANGED;
        ///scnNotification->nmhdr.hwndFrom = newIndex;
        ///scnNotification->nmhdr.idFrom = BufferID;
        /// </summary>
        NPPN_DOCORDERCHANGED = NPPN_FIRST + 17,

        /// <summary>
        ///scnNotification->nmhdr.code = NPPN_SNAPSHOTDIRTYFILELOADED;
        ///scnNotification->nmhdr.hwndFrom = NULL;
        ///scnNotification->nmhdr.idFrom = BufferID;
        /// </summary>
        NPPN_SNAPSHOTDIRTYFILELOADED = NPPN_FIRST + 18,

        /// <summary>
        ///scnNotification->nmhdr.code = NPPN_BEFORESHUTDOWN;
        ///scnNotification->nmhdr.hwndFrom = hwndNpp;
        ///scnNotification->nmhdr.idFrom = 0;
        /// </summary>
        NPPN_BEFORESHUTDOWN = NPPN_FIRST + 19,

        /// <summary>
        ///scnNotification->nmhdr.code = NPPN_CANCELSHUTDOWN;
        ///scnNotification->nmhdr.hwndFrom = hwndNpp;
        ///scnNotification->nmhdr.idFrom = 0;
        /// </summary>
        NPPN_CANCELSHUTDOWN = NPPN_FIRST + 20,

        /// <summary>
        ///scnNotification->nmhdr.code = NPPN_FILEBEFORERENAME;
        ///scnNotification->nmhdr.hwndFrom = hwndNpp;
        ///scnNotification->nmhdr.idFrom = BufferID;
        /// </summary>
        NPPN_FILEBEFORERENAME = NPPN_FIRST + 21,

        /// <summary>
        ///scnNotification->nmhdr.code = NPPN_FILERENAMECANCEL;
        ///scnNotification->nmhdr.hwndFrom = hwndNpp;
        ///scnNotification->nmhdr.idFrom = BufferID;
        /// </summary>
        NPPN_FILERENAMECANCEL = NPPN_FIRST + 22,

        /// <summary>
        ///scnNotification->nmhdr.code = NPPN_FILERENAMED;
        ///scnNotification->nmhdr.hwndFrom = hwndNpp;
        ///scnNotification->nmhdr.idFrom = BufferID;
        /// </summary>
        NPPN_FILERENAMED = NPPN_FIRST + 23,

        /// <summary>
        ///scnNotification->nmhdr.code = NPPN_FILEBEFOREDELETE;
        ///scnNotification->nmhdr.hwndFrom = hwndNpp;
        ///scnNotification->nmhdr.idFrom = BufferID;
        /// </summary>
        NPPN_FILEBEFOREDELETE = NPPN_FIRST + 24,

        /// <summary>
        ///scnNotification->nmhdr.code = NPPN_FILEDELETEFAILED;
        ///scnNotification->nmhdr.hwndFrom = hwndNpp;
        ///scnNotification->nmhdr.idFrom = BufferID;
        /// </summary>
        NPPN_FILEDELETEFAILED = NPPN_FIRST + 25,

        /// <summary>
        ///scnNotification->nmhdr.code = NPPN_FILEDELETED;
        ///scnNotification->nmhdr.hwndFrom = hwndNpp;
        ///scnNotification->nmhdr.idFrom = BufferID;
        /// </summary>
        NPPN_FILEDELETED = NPPN_FIRST + 26,

        /* --Autogenerated -- end of section automatically generated from notepad-plus-plus\PowerEditor\src\MISC\PluginsManager\Notepad_plus_msgs.h * */
    }
}
