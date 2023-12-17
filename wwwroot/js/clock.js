function showTime() {
    let time = new Date();
    let hour = time.getHours();
    let minute = time.getMinutes();
    let second = time.getSeconds();

    if (second < 10) {
        second = "0" + second;
    }

    let currentTime = hour + ":" + minute + ":" + second;
    $("#clock").html(currentTime);
    console.log(currentTime);
}

setInterval(showTime, 1000);

showTime();