
var arr = ["0:33:36", "0:30:10","0:09:54", "0:20:37", 
"0:15:35", "0:17:33", "0:32:42", "0:32:11", "0:09:58", "0:33:41", "0:24:57", "0:27:31", "0:10:00", "0:08:50", "0:24:45", "0:25:23"];
function mergeTime(times){
    var all = 0;
    for(var j = 0; j < times.length; j ++){
        var i = times[j].indexOf(":");
        var h = times[j].substr(0, i);
        var il = times[j].lastIndexOf(":");
        var m = times[j].substring(i + 1, il);
        var s = times[j].substr(il + 1);
        all += parseInt(s);
        all += parseInt(m) * 60;
        all += parseInt(h) * 3600;
    }
    var h = Math.floor(all / 3600);
    var m = Math.floor((all - 3600 * h) / 60);
    var s = all % 60;
    m = m > 9 ? m : '0' + m;
    s = s > 9 ? s : '0' + s;
    return h + ":" + m + ":" + s;
}
var time = mergeTime(arr);
console.log(time);