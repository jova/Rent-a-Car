$(document).ready(function () {

    const options = {
        scales: {
            yAxes: [{
                ticks: {
                    beginAtZero: true
                }
            }]
        }
    };

    $.ajax
        ({
            url: 'http://localhost:52935/api/company/EarningExpense?id=1',

            success: function (data) {

                var elemAylikKazanc = document.getElementById('chartAylikKazanc').getContext('2d');

                new Chart(elemAylikKazanc, {
                    type: 'pie',
                    data: {
                        labels: data.label,
                        datasets: [{
                            label: data.title,
                            data: data.data,
                            backgroundColor: data.bgColor,
                            borderWidth: 3
                        }]
                    },
                    options: { responsive: true }
                });
            }
        });

    $.ajax
        ({
            url: 'http://localhost:52935/api/vehicles/HowManyRented',
            success: function (data) {

                var elemAracTakip = document.getElementById('chartAracTakip').getContext('2d');

                new Chart(elemAracTakip, {
                    type: 'bar',
                    data: {
                        labels: data.label,
                        datasets: [{
                            label: data.title,
                            data: data.data,
                            backgroundColor: data.bgColor,
                            borderWidth: 3
                        }]
                    },
                    options: options
                });
            }
        });

    $.ajax
        ({
            url: 'http://localhost:52935/api/vehicles/AllKmForVehicles',

            success: function (data) {

                var elemAracKm = document.getElementById('chartAracKm').getContext('2d');
                new Chart(elemAracKm, {
                    type: 'bar',
                    data: {
                        labels: data.label,
                        datasets: [{
                            label: data.title,
                            data: data.data,
                            backgroundColor: data.bgColor,
                            borderWidth: 3
                        }]
                    },
                    options: options
                });

            }
        });


    $("#getInvoice").on("click", function () {

        var value = $("#customerTc").val();
        window.location.href = "/Login/Invoice?tc=" + value;

    });


});