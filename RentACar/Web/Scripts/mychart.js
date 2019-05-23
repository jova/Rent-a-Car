const options = {
    scales: {
        yAxes: [{
            ticks: {
                beginAtZero: true
            }
        }]
    }
};

//data jquery ile restfuldan gelecek
var data = {
    label: ['red', 'blue', 'yellow', 'purple', 'gray'],
    data: [5, 2, 11, 6, 13],
    bgColor: ['rgba(255, 99, 132, 0.3)', 'rgba(54, 162, 235, 0.3)', 'rgba(255, 206, 86, 0.3)', 'rgba(23, 52, 205, 0.3)'],
    title: 'araç kilometresi'
};


var elemAylikKazanc = document.getElementById('chartAylikKazanc').getContext('2d');
var chartAylikKazanc = new Chart(elemAylikKazanc, {
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


var elemAracTakip = document.getElementById('chartAracTakip').getContext('2d');
var chartAracTakip = new Chart(elemAracTakip, {
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


var elemAracKm = document.getElementById('chartAracKm').getContext('2d');
var chartAracKm = new Chart(elemAracKm, {
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
