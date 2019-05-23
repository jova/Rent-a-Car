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

    var vehicleId = $("#vehicleId").val();

    $.ajax
        ({
            url: 'http://localhost:52935/api/vehicles/GetLastKms?Id=' + vehicleId,

            success: function (data) {

                var elemAracKm = document.getElementById('chartAracTakip').getContext('2d');
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

});