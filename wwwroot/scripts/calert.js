window.showCustomAlert = function (message) {
    alert(message);
}

window.getUserAgent = () => {
    return navigator.userAgent;
};
window.deviceInfo = {
    getDeviceInfo: function () {
        var userAgent = navigator.userAgent;
        var device = 'Unknown';
        var browser = 'Unknown';

        if (/Android/i.test(userAgent)) {
            device = 'Android';
        } else if (/iPhone|iPad|iPod/i.test(userAgent)) {
            device = 'iOS';
        } else if (/Windows/i.test(userAgent)) {
            device = 'Windows';
        } else if (/Mac/i.test(userAgent)) {
            device = 'Mac';
        } else if (/Linux/i.test(userAgent)) {
            device = 'Linux';
        }

        if (/Chrome/i.test(userAgent)) {
            browser = 'Chrome';
        } else if (/Firefox/i.test(userAgent)) {
            browser = 'Firefox';
        } else if (/Safari/i.test(userAgent)) {
            browser = 'Safari';
        } else if (/Edge/i.test(userAgent)) {
            browser = 'Edge';
        } else if (/Opera|OPR/i.test(userAgent)) {
            browser = 'Opera';
        } else if (/MSIE|Trident/i.test(userAgent)) {
            browser = 'Internet Explorer';
        }

        return { device: device, browser: browser };
    }
};
window.deviceInfoD = {
    getDeviceInfo: function () {
        var userAgent = navigator.userAgent;
        var device = 'Unknown';

        if (/Android/i.test(userAgent)) {
            device = 'Android';
        } else if (/iPhone|iPad|iPod/i.test(userAgent)) {
            device = 'iOS';
        } else if (/Windows/i.test(userAgent)) {
            device = 'Windows';
        } else if (/Mac/i.test(userAgent)) {
            device = 'Mac';
        } else if (/Linux/i.test(userAgent)) {
            device = 'Linux';
        }

        return device;
    }
};

window.deviceInfoB = {
    getDeviceInfo: function () {
        var userAgent = navigator.userAgent;
        var browser = 'Unknown';
        if (/Chrome/i.test(userAgent)) {
            browser = 'Chrome';
        } else if (/Firefox/i.test(userAgent)) {
            browser = 'Firefox';
        } else if (/Safari/i.test(userAgent)) {
            browser = 'Safari';
        } else if (/Edge/i.test(userAgent)) {
            browser = 'Edge';
        } else if (/Opera|OPR/i.test(userAgent)) {
            browser = 'Opera';
        } else if (/MSIE|Trident/i.test(userAgent)) {
            browser = 'Internet Explorer';
        }

        return browser;
    }
};