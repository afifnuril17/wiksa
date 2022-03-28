mergeInto(LibraryManager.library, {
 
    GetURLFromPage: function () {
        var returnStr = window.top.location.href;
        var bufferSize = lengthBytesUTF8(returnStr) + 1
        var buffer = _malloc(bufferSize);
        stringToUTF8(returnStr, buffer, bufferSize);
        return buffer;
    },
 
    FinishGame: function (path) {
        window.location.href="https://devgamification.psikologicare.com" + Pointer_stringify(path);
	localStorage.removeItem("from");
   },
   
   StartGame: function () {
       localStorage.setItem('start', false);
   }
});