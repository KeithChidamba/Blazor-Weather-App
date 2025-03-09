window.getGeolocation = (dotNetHelper) => {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(
            (position) => {
                dotNetHelper.invokeMethodAsync('ReceiveLocation', position.coords.latitude, position.coords.longitude);
            },
            (error) => {
                console.error('Error getting location', error);
            }
        );
    } else {
        console.error('Geolocation is not supported by this browser.');
    }
};
