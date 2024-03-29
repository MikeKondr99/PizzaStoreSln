﻿var cart = new Map();
var counter = 0;
const counterEl = document.getElementsByName("productCount");
loadCart();
function loadCart() {
    let cCart = getCookie("cart").split(',').filter(x => x != "");
    cCart.forEach(kv1 => {
        let kv = kv1.split(':');
        cart.set(kv[0], kv[1]);
        counter += parseInt(kv[1]);
    });
}

function getCookie(name) {
    let matches = document.cookie.match(new RegExp(
        "(?:^|; )" + name.replace(/([\.$?*|{}\(\)\[\]\\\/\+^])/g, '\\$1') + "=([^;]*)"
    ));
    return matches ? decodeURIComponent(matches[1]) : "";
}

function setCookie(cName, cValue, expDays) {
    let date = new Date();
    date.setTime(date.getTime() + (expDays * 24 * 60 * 60 * 1000));
    const expires = "expires=" + date.toUTCString();
    document.cookie = cName + "=" + cValue + "; " + expires + "; path=/";
}

function mapToObj(map) {
    var obj = {}
    map.forEach(function (v, k) {
        obj[k] = v
    })
    return obj
}

function addProd(id) {
    let button = document.getElementById(id);
    counter += 1;
    counterEl[0].innerHTML = counter;
    if (cart.has(id)) {
        let v = cart.get(id);
        cart.set(id, v + 1);
        button.innerHTML = v + 1;
    }
    else {
        cart.set(id, 1);
        button.innerHTML = 1;
    }
}

function cartToString() {
    return Array.from(cart).map(x => x[0] + ":" + x[1]).join(",");
}

function goCart() {
    window.open("https://" + document.location.host + "/cart?cart=" + cartToString(), "_self");
}