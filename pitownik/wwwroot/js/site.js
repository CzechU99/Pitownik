// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function valueChange(x) {
    if (x.checked) {
        x.value = 1;
    } else {
        x.value = 0;
    }
}

function checkLengthPesel(x) {
    if (!(x.value.length <= 11 && x.value.length >= 10)) {
        alert("PESEL 11 ZNAKÓW, NIP 10 ZNAKÓW!");
        x.value = "";
    }
}

function onlyNumberInput() {
    var key = event.which || event.keyCode;
    if (key && (key <= 47 || key >= 58) && (key != 8) && (key != 37) && (key != 39)) {
        event.preventDefault();
    }
}

function yearCheck(x) {
    if(x.value.length != 4) {
        alert("ROK MUSI ZAWIERAĆ 4 CYFRY!");
        x.value = "";
    }
}

function dayCheck(x) {
    if ((x.value.length != 2 || x.value.length != 1) && (x.value < 1 || x.value > 31)) {
        alert("POLE ZAWIERA NIEPOPRAWNĄ WARTOŚĆ!");
        x.value = "";
    }
}

function monthCheck(x) {
    if ((x.value.length != 2 || x.value.length != 1) && (x.value < 1 || x.value > 12)) {
        alert("POLE ZAWIERA NIEPOPRAWNĄ WARTOŚĆ!");
        x.value = "";
    }
}

function wylacz(x) {
    if (x.checked) {
        document.getElementById("wart10_2").disabled = true;
        document.getElementById("wart11_2").disabled = true;
        document.getElementById("wart11_1").disabled = true;
        document.getElementById("wart11_2").checked = false;
        document.getElementById("wart11_1").checked = false;
    } else {
        document.getElementById("wart10_2").disabled = false;
        document.getElementById("wart11_2").disabled = false;
        document.getElementById("wart11_1").disabled = false;
    }
}

function wylacz2(x) {
    if (x.checked) {
        document.getElementById("wart10_1").disabled = true;
    }else {
        document.getElementById("wart10_1").disabled = false;
    }
}

function test(x) {
    if (x.checked) {
        document.getElementById("wart11_2").disabled = true;
    }else {
        document.getElementById("wart11_2").disabled = false;
    }
}

function test2(x) {
    if (x.checked) {
        document.getElementById("wart11_1").disabled = true;
    } else {
        document.getElementById("wart11_1").disabled = false;
    }
}

function poczta(code) {
    const regex = /^[0-9]{2}-[0-9]{3}$/;

    if (!regex.test(code.value)) {
        alert('BŁĘDNY KOD POCZTOWY!');
        code.value = '';
    }
}

function letterBlock() {
    var key = event.which || event.keyCode;
    if ((key >= 65 && key <= 90) || (key >= 97 && key <= 122)) {
        event.preventDefault();
    }
}

function dwamiejsca(x) {
    if (x.value == "") {
        x.value = "0.00";
    }
    var liczba = x.value;
    liczba = parseFloat(liczba).toFixed(2);
    x.value = liczba;
}

function dodajKomorki1() {
    var wart52 = parseFloat(document.getElementById("wart52").value);
    var wart53 = parseFloat(document.getElementById("wart53").value);
    var wart57 = parseFloat(document.getElementById("wart57").value);
    var wart58 = parseFloat(document.getElementById("wart58").value);
    var wart52_57 = wart52 + wart57;
    var wart53_58 = wart53 + wart58;
    var wart54 = parseFloat(wart52_57 - wart53_58);
    var wart55 = parseFloat(wart53_58 - wart52_57);

    if (wart54 < 0) {
        document.getElementById("wart55").value = wart55.toFixed(2);
        document.getElementById("wart54").value = "0.00";
    } else {
        document.getElementById("wart54").value = wart54.toFixed(2);
        document.getElementById("wart55").value = "0.00";
    }
    //document.getElementById("wart54").value = wart54;
    //document.getElementById("wart55").value = wart55;

    var wart111 = parseFloat(document.getElementById("wart52").value);
    var wart222 = parseFloat(document.getElementById("wart57").value);
    var wart333 = parseFloat(document.getElementById("wart59").value);
    var wart444 = parseFloat(document.getElementById("wart62").value);
    var wart555 = parseFloat(document.getElementById("wart67").value);
    var wart666 = parseFloat(document.getElementById("wart69").value);
    var wart777 = parseFloat(document.getElementById("wart74").value);
    var wart888 = parseFloat(document.getElementById("wart76").value);
    var wart999 = parseFloat(document.getElementById("wart81").value);
    var wart1010 = parseFloat(document.getElementById("wart82").value);

    var wart1111 = parseFloat(document.getElementById("wart53").value);
    var wart2222 = parseFloat(document.getElementById("wart58").value);
    var wart3333 = parseFloat(document.getElementById("wart63").value);
    var wart4444 = parseFloat(document.getElementById("wart68").value);
    var wart5555 = parseFloat(document.getElementById("wart70").value);
    var wart6666 = parseFloat(document.getElementById("wart75").value);
    var wart7777 = parseFloat(document.getElementById("wart77").value);

    var wart11111 = parseFloat(document.getElementById("wart56").value);
    var wart22222 = parseFloat(document.getElementById("wart61").value);
    var wart33333 = parseFloat(document.getElementById("wart66").value);
    var wart44444 = parseFloat(document.getElementById("wart73").value);
    var wart55555 = parseFloat(document.getElementById("wart80").value);

    var wartSuma1 = parseFloat(wart111 + wart222 + wart333 + wart444 + wart555 + wart666 + wart777 + wart888 + wart999 + wart1010);
    var wartSuma2 = parseFloat(wart1111 + wart2222 + wart3333 + wart4444 + wart5555 + wart6666 + wart7777);
    var wartSuma3 = parseFloat(wart11111 + wart22222 + wart33333 + wart44444 + wart55555);

    document.getElementById("wart83").value = wartSuma1.toFixed(2);
    document.getElementById("wart84").value = wartSuma2.toFixed(2);
    if (parseFloat(wartSuma1 - wartSuma2) < 0) {
        document.getElementById("wart85").value = "0.00";
    } else {
        document.getElementById("wart85").value = parseFloat(wartSuma1 - wartSuma2).toFixed(2);
    }
    document.getElementById("wart86").value = wartSuma3.toFixed(2);

}

function dodajKomorki2() {
    var wart59 = parseFloat(document.getElementById("wart59").value);
    document.getElementById("wart60").value = wart59.toFixed(2);

    var wart111 = parseFloat(document.getElementById("wart52").value);
    var wart222 = parseFloat(document.getElementById("wart57").value);
    var wart333 = parseFloat(document.getElementById("wart59").value);
    var wart444 = parseFloat(document.getElementById("wart62").value);
    var wart555 = parseFloat(document.getElementById("wart67").value);
    var wart666 = parseFloat(document.getElementById("wart69").value);
    var wart777 = parseFloat(document.getElementById("wart74").value);
    var wart888 = parseFloat(document.getElementById("wart76").value);
    var wart999 = parseFloat(document.getElementById("wart81").value);
    var wart1010 = parseFloat(document.getElementById("wart82").value);

    var wart1111 = parseFloat(document.getElementById("wart53").value);
    var wart2222 = parseFloat(document.getElementById("wart58").value);
    var wart3333 = parseFloat(document.getElementById("wart63").value);
    var wart4444 = parseFloat(document.getElementById("wart68").value);
    var wart5555 = parseFloat(document.getElementById("wart70").value);
    var wart6666 = parseFloat(document.getElementById("wart75").value);
    var wart7777 = parseFloat(document.getElementById("wart77").value);

    var wart11111 = parseFloat(document.getElementById("wart56").value);
    var wart22222 = parseFloat(document.getElementById("wart61").value);
    var wart33333 = parseFloat(document.getElementById("wart66").value);
    var wart44444 = parseFloat(document.getElementById("wart73").value);
    var wart55555 = parseFloat(document.getElementById("wart80").value);

    var wartSuma1 = parseFloat(wart111 + wart222 + wart333 + wart444 + wart555 + wart666 + wart777 + wart888 + wart999 + wart1010);
    var wartSuma2 = parseFloat(wart1111 + wart2222 + wart3333 + wart4444 + wart5555 + wart6666 + wart7777);
    var wartSuma3 = parseFloat(wart11111 + wart22222 + wart33333 + wart44444 + wart55555);

    document.getElementById("wart83").value = wartSuma1.toFixed(2);
    document.getElementById("wart84").value = wartSuma2.toFixed(2);
    if (parseFloat(wartSuma1 - wartSuma2) < 0) {
        document.getElementById("wart85").value = "0.00";
    } else {
        document.getElementById("wart85").value = parseFloat(wartSuma1 - wartSuma2).toFixed(2);
    }
    document.getElementById("wart86").value = wartSuma3.toFixed(2);

}

function dodajKomorki3() {
    var wart62 = parseFloat(document.getElementById("wart62").value);
    var wart63 = parseFloat(document.getElementById("wart63").value);
    var wart67 = parseFloat(document.getElementById("wart67").value);
    var wart68 = parseFloat(document.getElementById("wart68").value);
    var wart62_67 = wart62 + wart67;
    var wart63_68 = wart63 + wart68;
    var wart64 = parseFloat(wart62_67 - wart63_68);
    var wart65 = parseFloat(wart63_68 - wart62_67);

    if (wart64 < 0) {
        document.getElementById("wart65").value = wart65.toFixed(2);
        document.getElementById("wart64").value = "0.00";
    } else {
        document.getElementById("wart64").value = wart64.toFixed(2);
        document.getElementById("wart65").value = "0.00";
    }

    //document.getElementById("wart64").value = wart64;
    //document.getElementById("wart65").value = wart65;

    var wart111 = parseFloat(document.getElementById("wart52").value);
    var wart222 = parseFloat(document.getElementById("wart57").value);
    var wart333 = parseFloat(document.getElementById("wart59").value);
    var wart444 = parseFloat(document.getElementById("wart62").value);
    var wart555 = parseFloat(document.getElementById("wart67").value);
    var wart666 = parseFloat(document.getElementById("wart69").value);
    var wart777 = parseFloat(document.getElementById("wart74").value);
    var wart888 = parseFloat(document.getElementById("wart76").value);
    var wart999 = parseFloat(document.getElementById("wart81").value);
    var wart1010 = parseFloat(document.getElementById("wart82").value);

    var wart1111 = parseFloat(document.getElementById("wart53").value);
    var wart2222 = parseFloat(document.getElementById("wart58").value);
    var wart3333 = parseFloat(document.getElementById("wart63").value);
    var wart4444 = parseFloat(document.getElementById("wart68").value);
    var wart5555 = parseFloat(document.getElementById("wart70").value);
    var wart6666 = parseFloat(document.getElementById("wart75").value);
    var wart7777 = parseFloat(document.getElementById("wart77").value);

    var wart11111 = parseFloat(document.getElementById("wart56").value);
    var wart22222 = parseFloat(document.getElementById("wart61").value);
    var wart33333 = parseFloat(document.getElementById("wart66").value);
    var wart44444 = parseFloat(document.getElementById("wart73").value);
    var wart55555 = parseFloat(document.getElementById("wart80").value);

    var wartSuma1 = parseFloat(wart111 + wart222 + wart333 + wart444 + wart555 + wart666 + wart777 + wart888 + wart999 + wart1010);
    var wartSuma2 = parseFloat(wart1111 + wart2222 + wart3333 + wart4444 + wart5555 + wart6666 + wart7777);
    var wartSuma3 = parseFloat(wart11111 + wart22222 + wart33333 + wart44444 + wart55555);

    document.getElementById("wart83").value = wartSuma1.toFixed(2);
    document.getElementById("wart84").value = wartSuma2.toFixed(2);
    if (parseFloat(wartSuma1 - wartSuma2) < 0) {
        document.getElementById("wart85").value = "0.00";
    } else {
        document.getElementById("wart85").value = parseFloat(wartSuma1 - wartSuma2).toFixed(2);
    }
    document.getElementById("wart86").value = wartSuma3.toFixed(2);

}

function dodajKomorki4() {
    var wart52 = parseFloat(document.getElementById("wart69").value);
    var wart53 = parseFloat(document.getElementById("wart70").value);
    var wart57 = parseFloat(document.getElementById("wart74").value);
    var wart58 = parseFloat(document.getElementById("wart75").value);
    var wart52_57 = wart52 + wart57;
    var wart53_58 = wart53 + wart58;
    var wart54 = parseFloat(wart52_57 - wart53_58);
    var wart55 = parseFloat(wart53_58 - wart52_57);

    if (wart54 < 0) {
        document.getElementById("wart72").value = wart55.toFixed(2);
        document.getElementById("wart71").value = "0.00";
    } else {
        document.getElementById("wart71").value = wart54.toFixed(2);
        document.getElementById("wart72").value = "0.00";
    }

    //document.getElementById("wart71").value = wart54;
    //document.getElementById("wart72").value = wart55;

    var wart111 = parseFloat(document.getElementById("wart52").value);
    var wart222 = parseFloat(document.getElementById("wart57").value);
    var wart333 = parseFloat(document.getElementById("wart59").value);
    var wart444 = parseFloat(document.getElementById("wart62").value);
    var wart555 = parseFloat(document.getElementById("wart67").value);
    var wart666 = parseFloat(document.getElementById("wart69").value);
    var wart777 = parseFloat(document.getElementById("wart74").value);
    var wart888 = parseFloat(document.getElementById("wart76").value);
    var wart999 = parseFloat(document.getElementById("wart81").value);
    var wart1010 = parseFloat(document.getElementById("wart82").value);

    var wart1111 = parseFloat(document.getElementById("wart53").value);
    var wart2222 = parseFloat(document.getElementById("wart58").value);
    var wart3333 = parseFloat(document.getElementById("wart63").value);
    var wart4444 = parseFloat(document.getElementById("wart68").value);
    var wart5555 = parseFloat(document.getElementById("wart70").value);
    var wart6666 = parseFloat(document.getElementById("wart75").value);
    var wart7777 = parseFloat(document.getElementById("wart77").value);

    var wart11111 = parseFloat(document.getElementById("wart56").value);
    var wart22222 = parseFloat(document.getElementById("wart61").value);
    var wart33333 = parseFloat(document.getElementById("wart66").value);
    var wart44444 = parseFloat(document.getElementById("wart73").value);
    var wart55555 = parseFloat(document.getElementById("wart80").value);

    var wartSuma1 = parseFloat(wart111 + wart222 + wart333 + wart444 + wart555 + wart666 + wart777 + wart888 + wart999 + wart1010);
    var wartSuma2 = parseFloat(wart1111 + wart2222 + wart3333 + wart4444 + wart5555 + wart6666 + wart7777);
    var wartSuma3 = parseFloat(wart11111 + wart22222 + wart33333 + wart44444 + wart55555);

    document.getElementById("wart83").value = wartSuma1.toFixed(2);
    document.getElementById("wart84").value = wartSuma2.toFixed(2);
    if (parseFloat(wartSuma1 - wartSuma2) < 0) {
        document.getElementById("wart85").value = "0.00";
    } else {
        document.getElementById("wart85").value = parseFloat(wartSuma1 - wartSuma2).toFixed(2);
    }
    document.getElementById("wart86").value = wartSuma3.toFixed(2);

}

function dodajKomorki5() {
    var wart52 = parseFloat(document.getElementById("wart76").value);
    var wart53 = parseFloat(document.getElementById("wart81").value);
    var wart57 = parseFloat(document.getElementById("wart82").value);
    var wart58 = parseFloat(document.getElementById("wart77").value);
    var wart52_57 = wart52 + wart57 + wart53;
    var wart53_58 = wart53;
    var wart54 = parseFloat(wart52_57 - wart53_58);
    var wart55 = parseFloat(wart53_58 - wart52_57);

    if (wart54 < 0) {
        document.getElementById("wart79").value = wart55.toFixed(2);
        document.getElementById("wart78").value = "0.00";
    } else {
        document.getElementById("wart78").value = wart54.toFixed(2);
        document.getElementById("wart79").value = "0.00";
    }

    //document.getElementById("wart78").value = wart54;
    //document.getElementById("wart79").value = wart55;

    var wart111 = parseFloat(document.getElementById("wart52").value);
    var wart222 = parseFloat(document.getElementById("wart57").value);
    var wart333 = parseFloat(document.getElementById("wart59").value);
    var wart444 = parseFloat(document.getElementById("wart62").value);
    var wart555 = parseFloat(document.getElementById("wart67").value);
    var wart666 = parseFloat(document.getElementById("wart69").value);
    var wart777 = parseFloat(document.getElementById("wart74").value);
    var wart888 = parseFloat(document.getElementById("wart76").value);
    var wart999 = parseFloat(document.getElementById("wart81").value);
    var wart1010 = parseFloat(document.getElementById("wart82").value);

    var wart1111 = parseFloat(document.getElementById("wart53").value);
    var wart2222 = parseFloat(document.getElementById("wart58").value);
    var wart3333 = parseFloat(document.getElementById("wart63").value);
    var wart4444 = parseFloat(document.getElementById("wart68").value);
    var wart5555 = parseFloat(document.getElementById("wart70").value);
    var wart6666 = parseFloat(document.getElementById("wart75").value);
    var wart7777 = parseFloat(document.getElementById("wart77").value);

    var wart11111 = parseFloat(document.getElementById("wart56").value);
    var wart22222 = parseFloat(document.getElementById("wart61").value);
    var wart33333 = parseFloat(document.getElementById("wart66").value);
    var wart44444 = parseFloat(document.getElementById("wart73").value);
    var wart55555 = parseFloat(document.getElementById("wart80").value);

    var wartSuma1 = parseFloat(wart111 + wart222 + wart333 + wart444 + wart555 + wart666 + wart777 + wart888 + wart999 + wart1010);
    var wartSuma2 = parseFloat(wart1111 + wart2222 + wart3333 + wart4444 + wart5555 + wart6666 + wart7777);
    var wartSuma3 = parseFloat(wart11111 + wart22222 + wart33333 + wart44444 + wart55555);

    document.getElementById("wart83").value = wartSuma1.toFixed(2);
    document.getElementById("wart84").value = wartSuma2.toFixed(2);
    if (parseFloat(wartSuma1 - wartSuma2) < 0) {
        document.getElementById("wart85").value = "0.00";
    } else {
        document.getElementById("wart85").value = parseFloat(wartSuma1 - wartSuma2).toFixed(2);
    }
    document.getElementById("wart86").value = wartSuma3.toFixed(2);

}

function dodajKomorki11() {
    var wart52 = parseFloat(document.getElementById("wart87").value);
    var wart53 = parseFloat(document.getElementById("wart88").value);
    var wart57 = parseFloat(document.getElementById("wart92").value);
    var wart58 = parseFloat(document.getElementById("wart93").value);
    var wart52_57 = wart52 + wart57;
    var wart53_58 = wart53 + wart58;
    var wart54 = parseFloat(wart52_57 - wart53_58);
    var wart55 = parseFloat(wart53_58 - wart52_57);

    if (wart54 < 0) {
        document.getElementById("wart90").value = wart55.toFixed(2);
        document.getElementById("wart89").value = "0.00";
    } else {
        document.getElementById("wart89").value = wart54.toFixed(2);
        document.getElementById("wart90").value = "0.00";
    }

    //document.getElementById("wart89").value = wart54;
    //document.getElementById("wart90").value = wart55;

    var wart111 = parseFloat(document.getElementById("wart87").value);
    var wart222 = parseFloat(document.getElementById("wart92").value);
    var wart333 = parseFloat(document.getElementById("wart94").value);
    var wart444 = parseFloat(document.getElementById("wart97").value);
    var wart555 = parseFloat(document.getElementById("wart102").value);
    var wart666 = parseFloat(document.getElementById("wart104").value);
    var wart777 = parseFloat(document.getElementById("wart109").value);
    var wart888 = parseFloat(document.getElementById("wart111").value);
    var wart999 = parseFloat(document.getElementById("wart116").value);
    var wart1010 = parseFloat(document.getElementById("wart117").value);

    var wart1111 = parseFloat(document.getElementById("wart88").value);
    var wart2222 = parseFloat(document.getElementById("wart93").value);
    var wart3333 = parseFloat(document.getElementById("wart98").value);
    var wart4444 = parseFloat(document.getElementById("wart103").value);
    var wart5555 = parseFloat(document.getElementById("wart105").value);
    var wart6666 = parseFloat(document.getElementById("wart110").value);
    var wart7777 = parseFloat(document.getElementById("wart112").value);

    var wart11111 = parseFloat(document.getElementById("wart91").value);
    var wart22222 = parseFloat(document.getElementById("wart96").value);
    var wart33333 = parseFloat(document.getElementById("wart101").value);
    var wart44444 = parseFloat(document.getElementById("wart108").value);
    var wart55555 = parseFloat(document.getElementById("wart115").value);

    var wartSuma1 = parseFloat(wart111 + wart222 + wart333 + wart444 + wart555 + wart666 + wart777 + wart888 + wart999 + wart1010);
    var wartSuma2 = parseFloat(wart1111 + wart2222 + wart3333 + wart4444 + wart5555 + wart6666 + wart7777);
    var wartSuma3 = parseFloat(wart11111 + wart22222 + wart33333 + wart44444 + wart55555);

    document.getElementById("wart118").value = wartSuma1.toFixed(2);
    document.getElementById("wart119").value = wartSuma2.toFixed(2);
    if (parseFloat(wartSuma1 - wartSuma2) < 0) {
        document.getElementById("wart120").value = "0.00";
    } else {
        document.getElementById("wart120").value = parseFloat(wartSuma1 - wartSuma2).toFixed(2);
    }
    document.getElementById("wart121").value = wartSuma3.toFixed(2);

}

function dodajKomorki22() {
    var wart59 = parseFloat(document.getElementById("wart94").value);
    document.getElementById("wart95").value = wart59.toFixed(2);

    var wart111 = parseFloat(document.getElementById("wart87").value);
    var wart222 = parseFloat(document.getElementById("wart92").value);
    var wart333 = parseFloat(document.getElementById("wart94").value);
    var wart444 = parseFloat(document.getElementById("wart97").value);
    var wart555 = parseFloat(document.getElementById("wart102").value);
    var wart666 = parseFloat(document.getElementById("wart104").value);
    var wart777 = parseFloat(document.getElementById("wart109").value);
    var wart888 = parseFloat(document.getElementById("wart111").value);
    var wart999 = parseFloat(document.getElementById("wart116").value);
    var wart1010 = parseFloat(document.getElementById("wart117").value);

    var wart1111 = parseFloat(document.getElementById("wart88").value);
    var wart2222 = parseFloat(document.getElementById("wart93").value);
    var wart3333 = parseFloat(document.getElementById("wart98").value);
    var wart4444 = parseFloat(document.getElementById("wart103").value);
    var wart5555 = parseFloat(document.getElementById("wart105").value);
    var wart6666 = parseFloat(document.getElementById("wart110").value);
    var wart7777 = parseFloat(document.getElementById("wart112").value);

    var wart11111 = parseFloat(document.getElementById("wart91").value);
    var wart22222 = parseFloat(document.getElementById("wart96").value);
    var wart33333 = parseFloat(document.getElementById("wart101").value);
    var wart44444 = parseFloat(document.getElementById("wart108").value);
    var wart55555 = parseFloat(document.getElementById("wart115").value);

    var wartSuma1 = parseFloat(wart111 + wart222 + wart333 + wart444 + wart555 + wart666 + wart777 + wart888 + wart999 + wart1010);
    var wartSuma2 = parseFloat(wart1111 + wart2222 + wart3333 + wart4444 + wart5555 + wart6666 + wart7777);
    var wartSuma3 = parseFloat(wart11111 + wart22222 + wart33333 + wart44444 + wart55555);

    document.getElementById("wart118").value = wartSuma1.toFixed(2);
    document.getElementById("wart119").value = wartSuma2.toFixed(2);
    if (parseFloat(wartSuma1 - wartSuma2) < 0) {
        document.getElementById("wart120").value = "0.00";
    } else {
        document.getElementById("wart120").value = parseFloat(wartSuma1 - wartSuma2).toFixed(2);
    }
    document.getElementById("wart121").value = wartSuma3.toFixed(2);

}

function dodajKomorki33() {
    var wart62 = parseFloat(document.getElementById("wart97").value);
    var wart63 = parseFloat(document.getElementById("wart98").value);
    var wart67 = parseFloat(document.getElementById("wart102").value);
    var wart68 = parseFloat(document.getElementById("wart103").value);
    var wart62_67 = wart62 + wart67;
    var wart63_68 = wart63 + wart68;
    var wart64 = parseFloat(wart62_67 - wart63_68);
    var wart65 = parseFloat(wart63_68 - wart62_67);

    if (wart64 < 0) {
        document.getElementById("wart100").value = wart65.toFixed(2);
        document.getElementById("wart99").value = "0.00";
    } else {
        document.getElementById("wart99").value = wart64.toFixed(2);
        document.getElementById("wart100").value = "0.00";
    }

    //document.getElementById("wart99").value = wart64;
    //document.getElementById("wart100").value = wart65;

    var wart111 = parseFloat(document.getElementById("wart87").value);
    var wart222 = parseFloat(document.getElementById("wart92").value);
    var wart333 = parseFloat(document.getElementById("wart94").value);
    var wart444 = parseFloat(document.getElementById("wart97").value);
    var wart555 = parseFloat(document.getElementById("wart102").value);
    var wart666 = parseFloat(document.getElementById("wart104").value);
    var wart777 = parseFloat(document.getElementById("wart109").value);
    var wart888 = parseFloat(document.getElementById("wart111").value);
    var wart999 = parseFloat(document.getElementById("wart116").value);
    var wart1010 = parseFloat(document.getElementById("wart117").value);

    var wart1111 = parseFloat(document.getElementById("wart88").value);
    var wart2222 = parseFloat(document.getElementById("wart93").value);
    var wart3333 = parseFloat(document.getElementById("wart98").value);
    var wart4444 = parseFloat(document.getElementById("wart103").value);
    var wart5555 = parseFloat(document.getElementById("wart105").value);
    var wart6666 = parseFloat(document.getElementById("wart110").value);
    var wart7777 = parseFloat(document.getElementById("wart112").value);

    var wart11111 = parseFloat(document.getElementById("wart91").value);
    var wart22222 = parseFloat(document.getElementById("wart96").value);
    var wart33333 = parseFloat(document.getElementById("wart101").value);
    var wart44444 = parseFloat(document.getElementById("wart108").value);
    var wart55555 = parseFloat(document.getElementById("wart115").value);

    var wartSuma1 = parseFloat(wart111 + wart222 + wart333 + wart444 + wart555 + wart666 + wart777 + wart888 + wart999 + wart1010);
    var wartSuma2 = parseFloat(wart1111 + wart2222 + wart3333 + wart4444 + wart5555 + wart6666 + wart7777);
    var wartSuma3 = parseFloat(wart11111 + wart22222 + wart33333 + wart44444 + wart55555);

    document.getElementById("wart118").value = wartSuma1.toFixed(2);
    document.getElementById("wart119").value = wartSuma2.toFixed(2);
    if (parseFloat(wartSuma1 - wartSuma2) < 0) {
        document.getElementById("wart120").value = "0.00";
    } else {
        document.getElementById("wart120").value = parseFloat(wartSuma1 - wartSuma2).toFixed(2);
    }
    document.getElementById("wart121").value = wartSuma3.toFixed(2);

}

function dodajKomorki44() {
    var wart52 = parseFloat(document.getElementById("wart104").value);
    var wart53 = parseFloat(document.getElementById("wart105").value);
    var wart57 = parseFloat(document.getElementById("wart109").value);
    var wart58 = parseFloat(document.getElementById("wart110").value);
    var wart52_57 = wart52 + wart57;
    var wart53_58 = wart53 + wart58;
    var wart54 = parseFloat(wart52_57 - wart53_58);
    var wart55 = parseFloat(wart53_58 - wart52_57);

    if (wart54 < 0) {
        document.getElementById("wart107").value = wart55.toFixed(2);
        document.getElementById("wart106").value = "0.00";
    } else {
        document.getElementById("wart106").value = wart54.toFixed(2);
        document.getElementById("wart107").value = "0.00";
    }

    //document.getElementById("wart106").value = wart54;
    //document.getElementById("wart107").value = wart55;

    var wart111 = parseFloat(document.getElementById("wart87").value);
    var wart222 = parseFloat(document.getElementById("wart92").value);
    var wart333 = parseFloat(document.getElementById("wart94").value);
    var wart444 = parseFloat(document.getElementById("wart97").value);
    var wart555 = parseFloat(document.getElementById("wart102").value);
    var wart666 = parseFloat(document.getElementById("wart104").value);
    var wart777 = parseFloat(document.getElementById("wart109").value);
    var wart888 = parseFloat(document.getElementById("wart111").value);
    var wart999 = parseFloat(document.getElementById("wart116").value);
    var wart1010 = parseFloat(document.getElementById("wart117").value);

    var wart1111 = parseFloat(document.getElementById("wart88").value);
    var wart2222 = parseFloat(document.getElementById("wart93").value);
    var wart3333 = parseFloat(document.getElementById("wart98").value);
    var wart4444 = parseFloat(document.getElementById("wart103").value);
    var wart5555 = parseFloat(document.getElementById("wart105").value);
    var wart6666 = parseFloat(document.getElementById("wart110").value);
    var wart7777 = parseFloat(document.getElementById("wart112").value);

    var wart11111 = parseFloat(document.getElementById("wart91").value);
    var wart22222 = parseFloat(document.getElementById("wart96").value);
    var wart33333 = parseFloat(document.getElementById("wart101").value);
    var wart44444 = parseFloat(document.getElementById("wart108").value);
    var wart55555 = parseFloat(document.getElementById("wart115").value);

    var wartSuma1 = parseFloat(wart111 + wart222 + wart333 + wart444 + wart555 + wart666 + wart777 + wart888 + wart999 + wart1010);
    var wartSuma2 = parseFloat(wart1111 + wart2222 + wart3333 + wart4444 + wart5555 + wart6666 + wart7777);
    var wartSuma3 = parseFloat(wart11111 + wart22222 + wart33333 + wart44444 + wart55555);

    document.getElementById("wart118").value = wartSuma1.toFixed(2);
    document.getElementById("wart119").value = wartSuma2.toFixed(2);
    if (parseFloat(wartSuma1 - wartSuma2) < 0) {
        document.getElementById("wart120").value = "0.00";
    } else {
        document.getElementById("wart120").value = parseFloat(wartSuma1 - wartSuma2).toFixed(2);
    }
    document.getElementById("wart121").value = wartSuma3.toFixed(2);

}

function dodajKomorki55() {
    var wart52 = parseFloat(document.getElementById("wart111").value);
    var wart53 = parseFloat(document.getElementById("wart116").value);
    var wart57 = parseFloat(document.getElementById("wart117").value);
    var wart58 = parseFloat(document.getElementById("wart112").value);
    var wart52_57 = wart52 + wart57 + wart53;
    var wart53_58 = wart53;
    var wart54 = parseFloat(wart52_57 - wart53_58);
    var wart55 = parseFloat(wart53_58 - wart52_57);

    if (wart54 < 0) {
        document.getElementById("wart114").value = wart55.toFixed(2);
        document.getElementById("wart113").value = "0.00";
    } else {
        document.getElementById("wart113").value = wart54.toFixed(2);
        document.getElementById("wart114").value = "0.00";
    }

    //document.getElementById("wart113").value = wart54;
    //document.getElementById("wart114").value = wart55;

    var wart111 = parseFloat(document.getElementById("wart87").value);
    var wart222 = parseFloat(document.getElementById("wart92").value);
    var wart333 = parseFloat(document.getElementById("wart94").value);
    var wart444 = parseFloat(document.getElementById("wart97").value);
    var wart555 = parseFloat(document.getElementById("wart102").value);
    var wart666 = parseFloat(document.getElementById("wart104").value);
    var wart777 = parseFloat(document.getElementById("wart109").value);
    var wart888 = parseFloat(document.getElementById("wart111").value);
    var wart999 = parseFloat(document.getElementById("wart116").value);
    var wart1010 = parseFloat(document.getElementById("wart117").value);

    var wart1111 = parseFloat(document.getElementById("wart88").value);
    var wart2222 = parseFloat(document.getElementById("wart93").value);
    var wart3333 = parseFloat(document.getElementById("wart98").value);
    var wart4444 = parseFloat(document.getElementById("wart103").value);
    var wart5555 = parseFloat(document.getElementById("wart105").value);
    var wart6666 = parseFloat(document.getElementById("wart110").value);
    var wart7777 = parseFloat(document.getElementById("wart112").value);

    var wart11111 = parseFloat(document.getElementById("wart91").value);
    var wart22222 = parseFloat(document.getElementById("wart96").value);
    var wart33333 = parseFloat(document.getElementById("wart101").value);
    var wart44444 = parseFloat(document.getElementById("wart108").value);
    var wart55555 = parseFloat(document.getElementById("wart115").value);

    var wartSuma1 = parseFloat(wart111 + wart222 + wart333 + wart444 + wart555 + wart666 + wart777 + wart888 + wart999 + wart1010);
    var wartSuma2 = parseFloat(wart1111 + wart2222 + wart3333 + wart4444 + wart5555 + wart6666 + wart7777);
    var wartSuma3 = parseFloat(wart11111 + wart22222 + wart33333 + wart44444 + wart55555);

    document.getElementById("wart118").value = wartSuma1.toFixed(2);
    document.getElementById("wart119").value = wartSuma2.toFixed(2);
    if (parseFloat(wartSuma1 - wartSuma2) < 0) {
        document.getElementById("wart120").value = "0.00";
    } else {
        document.getElementById("wart120").value = parseFloat(wartSuma1 - wartSuma2).toFixed(2);
    }
    document.getElementById("wart121").value = wartSuma3.toFixed(2);

}

function check85(x) {
    if (x.value > parseFloat(document.getElementById("wart85").value)) {
        alert("Wartość nie może być większa od wartości w komórce 85");
        x.value = "0.00";
    }
}

function check120(x) {
    if (x.value > parseFloat(document.getElementById("wart120").value)) {
        alert("Wartość nie może być większa od wartości w komórce 120");
        x.value = "0.00";
    }
}

function check124(x) {
    if (x.value > (parseFloat(document.getElementById("wart85").value) - parseFloat(document.getElementById("wart122").value))) {
        alert("Wartość nie może być większa od wartości w komórce 85 pomniejszonej o komorke 122!");
        x.value = "0.00";
    }
}

function check125(x) {
    if (x.value > (parseFloat(document.getElementById("wart120").value) - parseFloat(document.getElementById("wart123").value))) {
        alert("Wartość nie może być większa od wartości w komórce 120 pomniejszonej o komorke 123!");
        x.value = "0.00";
    }
}

function check126(x) {
    if (x.value > ((parseFloat(document.getElementById("wart85").value) + parseFloat(document.getElementById("wart120").value)) - (parseFloat(document.getElementById("wart122").value) + parseFloat(document.getElementById("wart123").value) + parseFloat(document.getElementById("wart124").value) + parseFloat(document.getElementById("wart126").value)))) {
        alert("Odliczenie nie może przekroczyć sumy kwot z poz. 85 i 120 pomniejszonej o sumę kwot z poz. 122, 123, 124 i 125!");
        x.value = "0.00";
    }
}

function check127(x) {
    x.value = ((parseFloat(document.getElementById("wart85").value) + parseFloat(document.getElementById("wart120").value)) - (parseFloat(document.getElementById("wart122").value) + parseFloat(document.getElementById("wart123").value) + parseFloat(document.getElementById("wart124").value) + parseFloat(document.getElementById("wart125").value) + parseFloat(document.getElementById("wart126").value)));   
}

function check128(x) {
    if (x.value > parseFloat(document.getElementById("wart127").value)){
        alert("Wartość nie może być większa od wartości w komórce 127!");
        x.value = parseFloat(document.getElementById("wart127").value);
    }
}

function check129(x) {
    if (documnet.getElementById("wart6_1").checked) {
        x.value = parseFloat(documnet.getElementById("wart127").value) - parseFloat(documnet.getElementById("wart128").value);
    } else {
        x.value = (parseFloat(documnet.getElementById("wart127").value) - parseFloat(documnet.getElementById("wart128").value))/2;
    }
}

function check130(x) {
    if (document.getElementById("wart6_2").checked || document.getElementById("wart6_3").checked || document.getElementById("wart6_4").checked) {
        var liczba = parseFloat(document.getElementById("wart129").value) * 2;
        if (liczba < 0) {
            x.value = 0;
        } else {
            x.value = liczba;
        }
    }
}

function check133(x) {
    if (x.value > (parseFloat(document.getElementById("wart130").value) + parseFloat(document.getElementById("wart132").value))) {
        alert("Wartość nie może przekroczyć sumy kwot z komórek 130 i 132!");
        x.value="0.00";
    }
}

function check135(x) {
    x.value = (parseFloat(document.getElementById("wart130").value) + parseFloat(document.getElementById("wart132").value)) - (parseFloat(document.getElementById("wart133").value) + parseFloat(document.getElementById("wart134").value));
}

function check136(x) {
    if (x.value > parseFloat(document.getElementById("wart135").value)){
        alert("Wartość nie może być większa od wartości w komórce 135!");
        x.value = parseFloat(document.getElementById("wart135").value);
    }
}

function check137(x) {
    x.value = Math.round(parseFloat(document.getElementById("wart135").value) - parseFloat(document.getElementById("wart136").value));
}

function check138(x) {
    var liczba = parseFloat(document.getElementById("wart137").value - (parseFloat(document.getElementById("wart86").value) + parseFloat(document.getElementById("wart121").value)));
    if (liczba < 0) {
        x.value = 0;
    } else {
        x.value = liczba;
    }
}

function check139(x) {
    var liczba = (parseFloat(document.getElementById("wart86").value + parseFloat(document.getElementById("wart121").value))) - parseFloat(document.getElementById("wart137"));
    if (liczba < 0) {
        x.value = 0;
    } else {
        x.value = liczba;
    }
}

function check144(x) {
    var liczba = parseFloat(document.getElementById("wart142").value) + parseFloat(document.getElementById("wart143").value);
    var liczba2 = parseFloat(document.getElementById("wart140").value) + parseFloat(document.getElementById("wart141").value);
    if (liczba > liczba2) {
        x.value = liczba2;
    } else {
        x.value = liczba;
    }
}

function check145(x) {
    x.value = parseFloat(document.getElementById("wart144").value) + parseFloat(document.getElementById("wart139").value);
}

function checkLengthKRS(x) {
    if (x.value.length != 10) {
        alert("Numer KRS musi mieć 10 znaków!");
        x.value = "";
    }
}

function check148(x) {
    var liczba = Math.round(parseFloat(document.getElementById("wart137").value) * 1.5);
    if (x.value > liczba) {
        alert("ZBYT DUŻA KWOTA!");
        x.value = "0.00";
    }
}

function wylacz3(x) {
    if (x.checked) {
        document.getElementById("wart156_2").disabled = true;
        document.getElementById("wart158").disabled = true;
        document.getElementById("wart158").value = "";
    } else {
        document.getElementById("wart156_2").disabled = false;
        document.getElementById("wart158").disabled = false;
    }
}

function wylacz4(x) {
    if (x.checked) {
        document.getElementById("wart156_1").disabled = true;
        document.getElementById("wart158").disabled = false;
    } else {
        document.getElementById("wart156_1").disabled = false;
        document.getElementById("wart158").disabled = true;
    }
}

function wylacz5(x) {
    if (x.checked) {
        document.getElementById("wart157_2").disabled = true;
        document.getElementById("wart157_3").disabled = true;
    } else {
        document.getElementById("wart157_3").disabled = false;
        document.getElementById("wart157_2").disabled = false;
    }
}

function wylacz6(x) {
    if (x.checked) {
        document.getElementById("wart157_1").disabled = true;
        document.getElementById("wart157_3").disabled = true;
    } else {
        document.getElementById("wart157_3").disabled = false;
        document.getElementById("wart157_1").disabled = false;
    }
}

function wylacz7(x) {
    if (x.checked) {
        document.getElementById("wart157_2").disabled = true;
        document.getElementById("wart157_1").disabled = true;
    } else {
        document.getElementById("wart157_1").disabled = false;
        document.getElementById("wart157_2").disabled = false;
    }
}

function check6_2(x) {
    if (x.checked) {
        document.getElementById("wart159_2").disabled = false;
        document.getElementById("wart164_2").disabled = false;
    } else {
        document.getElementById("wart159_2").disabled = true;
        document.getElementById("wart164_2").disabled = true;
    }
}

function check162(x) {
    if (x.value.length > 3) {
        x.value = "";
        alert("NIEPOPRAWNY SYMBOL WALUTY!");
    }
}

function check163(x) {
    if (!(x.value.length == 8 || x.value.length == 28)) {
        x.value = "";
        alert("NIEPOPRAWNY NUMER RACHUNKU!");
    }
}