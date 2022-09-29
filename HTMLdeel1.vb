Uitleg deel 1:

<style> 

</style>

<script>
    // VARIABELE
    // DOM = Document Object Model
    function mijnfunctie(){     // eventlistener
        alert("Hij doet het!");
        var x = 10;
        console.log(x);
        x++;
        console.log(x);
        console.log("======HIER MOET JE KIJKEN");
        var element = document.getElementById("detitel");
        console.log(element.innerHTML);
        element.innerHTML = "Stuk nieuwe tekst";
        element.style.backgroundColor = 'red';

        var y = 25;
        if (y > 10) {
            alert("Value is groter dan 10");
        }

        var var1 = document.getElementById("tekstveldje");
        console.log(var1.value);

    }

    function tweedefunctie(){
        console.log("Dit is heel wat anders...");
    }


</script>

<input id="tekstveldje">

<h1 onclick="tweedefunctie()" id="detitel">We zijn van start</h1>

<div onclick="mijnfunctie()">Hier kan ik vanalles</div>
