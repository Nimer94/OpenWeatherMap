
$(document).ready(function () {
    $('#Searchbtn').click(function (e) {
        e.preventDefault();
        showProgress();
        $.ajax({
            url: "https://api.openweathermap.org/data/2.5/weather?q=" + $('#CityName').val() + "&units=metric" + "&APPID=5e0e99b3c0a4d9dd264ce9cf07774bc7",
            type: 'GET',
            success: function (data) {
                var formdata = new FormData();
                var iconimg = "http://openweathermap.org/img/w/" + data.weather[0].icon + ".png";
                formdata.append("CityName", data.name);
                formdata.append("CountryCode", data.sys.country);
                formdata.append("CurrentTemperature", data.main.temp);
                formdata.append("MinimumTemperature", data.main.temp_max);
                formdata.append("MaximumTemperature", data.main.temp_min);
                formdata.append("Humidity", data.main.humidity);
                formdata.append("AirPressure", data.main.pressure);
                formdata.append("WindSpeed", data.wind.speed);
                formdata.append("WindDirection", data.wind.deg);
                formdata.append("Cloudcovercondition", data.weather[0].main);
                formdata.append("WeatherIconImg", iconimg);
                $.ajax({
                    url: "/Weathers/Create",
                    type: "POST",
                    data: formdata,
                    processData: false,
                    contentType: false,
                    success: function (response) {
                        hideProgress();
                        $("#Weatherinfodiv").html(response);
                    },
                    error: function () {
                        hideProgress();
                        alert("An error has been occurred !!!");
                        $('#AddBtn').attr("disabled", false);
                    }
                });
            },
            error: function () {
                hideProgress();
                alert("error");
            }
        });
    });

});