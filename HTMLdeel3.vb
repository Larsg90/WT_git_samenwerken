Uitleg deel 2:
--> ARRAY []

<script>
    let vary = 10;  // globale variabele
    let rijtje = [5, 20, 14, 154, 202, 55, 22];
    function heetWelkom(){        
        let varx = 0; // locale variabele
        varx++;
        vary--;
        console.log(varx);
        console.log(vary);
        if(vary < 0){
            document.getElementById("DeTitel").innerHTML = "je bent af";
        }
        console.log( rijtje[2] );
        console.log(rijtje)
        let vari = 0;
        console.log(rijtje[vari]);
        vari ++;
        console.log(rijtje[vari]);
        for(var x = 0 ;  x < rijtje.length   ;  x++  ){   
            console.log("print in for loop"+x);
            console.log(rijtje[x]);
        }
        // casten  parsen
        var getal = document.getElementById("Invoernaam").value;
        getal = parseInt(getal);
        // alert(getal + getal);
        rijtje.push(getal);
        console.log(rijtje);
        toonBoodschappenlijstje();
    }
    function toonBoodschappenlijstje(){
        var lijstje = document.getElementById("boodschappenoverzicht");
        lijstje.innerHTML = "";
        for(let x in rijtje){
            lijstje.innerHTML += rijtje[x];
        }
    }
</script>
<hr><hr>
<h1 id="DeTitel"></h1>
<input id="Invoernaam">
<input type="button" value="Klik hier" onclick="heetWelkom()">
<div id="boodschappenoverzicht"></div>

