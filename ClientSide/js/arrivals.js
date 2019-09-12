window.onload = function() {
    let items;
    fetch(`${config.apiDomain}/api/data/getnewarrivals`)
        .then(response => response.json())
        .then((res) => {
            $.each(res, (key, value) => {
                $("<div class='list__item'></div>").appendTo(".new-arrivals__list");
                $(`<div class='item__holder' id='item__holder${key + 1}'></div>`)
                .appendTo(`.list__item:nth-child(${key + 1})`);
                $("<a href='item.html'></a>").appendTo(`#item__holder${key + 1}`);
                $("<div class='item__image'></div>").appendTo(`#item__holder${key + 1}>a`);
                $(`<img src='${config.apiDomain + value.images[0]}'>`)
                     .appendTo(`#item__holder${key + 1} .item__image`);
                $(`<div class='item__description'>
                    <div class='item__name'>
                        <a href='item.html'>${value.name}</a>
                    </div>
                    <div class='item_price'>&#163;${value.price.toFixed(2)}</div>
                </div>`).appendTo(`.list__item:nth-child(${key + 1})`);

            });
            
        });
}