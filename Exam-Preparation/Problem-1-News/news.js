window.onload = function () {

    var templateNode = document.getElementById('news-articles-template');
    var templateString = templateNode.innerHTML;
    var template = Handlebars.compile(templateString);

    var news = [
        {
            image: "3. school.jpg",
            title: "Започват ремонтите в училищата и детските градини в София",
            date: "13.06 | 21:32",
            info: "Столичната община дава над 7 милиона лева за обновяването"
        },
        {
            image: "4. vegetables.jpg",
            title: "Доматите и краставиците са с 22% по-евтини",
            date: "12.06 | 21:22",
            info: "Според данните на НСИ цените на стоките и услугите у нас намаляват"
        },
        {
            image: "5. cars.jpg",
            title: "Полицаите на шофьорски изпит, ако управляват служебни коли",
            date: "13.06 | 21:12",
            info: "Kоито покажат слаб резултат, няма да могат да карат по време на работа"
        }
    ];

    var singleArticle = template({news: news});
    document.body.innerHTML += singleArticle;

}