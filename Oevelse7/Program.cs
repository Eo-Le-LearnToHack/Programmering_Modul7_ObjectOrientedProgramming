// See https://aka.ms/new-console-template for more information

/*Øvelse 7.1
Lav en klasse som indeholder en metode, som udskriver teksten Hej Verden.

Du bestemmer selv, hvad din klasse og din metode skal hedde.

Skriv også et program som opretter en instans af klassen og kalder metoden.


💡 Du kan bruge operatoren new til at oprette en instans af din klasse.

🤔 Tænk over om din klasse og metode skal være public eller private. Når du ser min løsning på opgaven, kan du høre mine overvejelser om det.

Se den vejledende løsning til 7.1 her.
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=f16cb1af-d8ef-4f3d-b8c1-ade5009f5a51
*/

//using Oevelse7;
//HejVerden velkomstHilsen = new();
//HejVerden.WelcomeMessage();



/*Øvelse 7.2
-ø-Lav en klasse med en metode som tager et tal som parameter. Metoden skal derefter udskrive teksten "Tallet er " efterfulgt af tallet.

Skriv også et program som opretter en instans af klassen og kalder metoden.

Se den vejledende løsning til 7.2 her.
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=232f9642-dbda-4029-a9cf-ade5009f59be
*/

//using Oevelse7;
//ReadNumber mitTal = new();
//mitTal.ReadNumber_Met("333");



/*Øvelse 7.3
Lav en klasse med en metode, som tager to tal som parametre. 
Metoden skal derefter udskrive teksten "Summen af de to tal er " 
efterfulgt at resultatet af de to tal lagt sammen (altså tal1 + tal2)

Skriv også et program som opretter en instans af klassen og kalder metoden.

Se den vejledende løsning til 7.3 her.
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=51be2b17-7889-4937-8938-ade5009f8bf2
*/

//using Oevelse7;
//Sum mitTal = new();
//mitTal.Sum_met(33, 5);


/*Øvelse 7.4
Lav en klasse med en metode, som tager to tal som parametre. 
Metoden skal derefter returnere (altså ikke udskrive) forskellen mellem de to tal (altså tal1 - tal2).

Skriv også et program som opretter en instans af klassen, kalder metoden og udskriver metodens resultat.

💡 Du bruger ordet return til at returnere en værdi fra en funktion.

Se den vejledende løsning til 7.4 her.
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=5218f928-8d43-4c29-b8c2-ade5009f7e8d
*/

//using Oevelse7;
//Difference mitTal = new();
//Console.WriteLine($"Differencen er {mitTal.Difference_met(33, 5)}");


/*Øvelse 7.5
Lav en klasse med to metoder og en instansvariabel (også kaldet et felt, en egenskab eller et field). 

Metoderne skal hedde Plus og Sum. 

Instansvariablen skal hedde Total.

Plus-metoden skal have én parameter. Metoden skal lægge værdien af parameteren til variablen Total.

Metoden Sum skal udskrive den værdi, som variablen Total har.

Lav en program, som bruger klassen.

🤔 Skal Total være private, public -eller noget helt andet? 

Se den vejledende løsning til 7.5 her.
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=388b8212-c302-4d39-bd1b-ade5009f79c3

*/

//using Oevelse7;
//PlusSumTotal minSum = new();
//minSum.Plus_met(4);
//minSum.Plus_met(16);
//Console.WriteLine(minSum.Sum_met());


/*Øvelse 7.6
Lav en klasse, der hedder Person. 
Klassen skal have to felter: Navn og Email. 

Derudover skal klassen have en metode Udskriv, som udskriver både Navn og Email på skærmen.

Lav også et program, som bruger klassen.

Se den vejledende løsning til 7.6 her.
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=645d1835-29f0-45e4-8747-ade5009f7675
*/

//using Oevelse7;
//using System;
//Personer person1 = new();
//person1.Navn = "Chi Dan Nguyen";
//person1.Email = "Eo-Le@hotmail.com";
//person1.Udskriv();



/*Øvelse 7.7
Lav en klasse, der hedder Vare. 
Klassen skal have to felter: Navn og Pris.
Derudover skal klassen have en metode Udskriv, som udskriver både Navn og Pris på skærmen.

Lav derudover klassen Kasseapparat 
som har en metode, der hedder UdskrivBon. 
Den metode tager en parameter, som er et array af objekter af klassen Vare. 
Metoden UdskrivBon skal udskrive alle varerne i array'et.

🤔 Husk at prisen er et beløb, som skal formatteres pænt, når det udskrives.

Se den vejledende løsning til 7.7 her.
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=a4f97aab-3bd8-402f-b7cc-adea015d4464
*/

//using Oevelse7;
//Vare vare1 = new();
//vare1.Navn = "æble";
//vare1.Pris = 12.25;
//Vare vare2 = new();
//vare2.Navn = "pære";
//vare2.Pris = 15;
//Vare vare3 = new();
//vare3.Navn = "ananas";
//vare3.Pris = 35;
//Vare[] AlleVarerne = { vare1, vare2, vare3 };
//Kasseapparat udskrivVarerne = new();
//udskrivVarerne.Udskriv(AlleVarerne);


/*Øvelse 7.8
Lav en klasse, Lysregulering, som har feltet Farve. 
Det afspejler farven i lysreguleringen (rød, gul, eller grøn). 
Lav en default constructor (standard-konstruktør) som sætter farven til rød, når klassen instantieres.

Se den vejledende løsning til 7.8 her.
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=6cafa5e0-6e61-463c-b988-ade5009f6509
*/



/*Øvelse 7.9
Lav en klasse By, som har felterne Navn og Indbyggerantal. Lav en constructor, som kan bruges til at angive byens navn, når man instantierer klassen.

Lav en anden constructor, som kan bruges til både at angive byens navn og indbyggerantallet.

Se den vejledende løsning til 7.9 her.
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=1ef06aaa-ba67-4bfb-9c13-ade5009f5a28
*/



/*Øvelse 7.10
Lav en klasse, Regn, som har to felter: Dag og Nedbør. De indeholder henholdsvis navnet på en ugedag og mængden af nedbør (i mm) den dag.

Lav en anden klasse, Vejr, som har en metode SamletNedbør.Den tager to instanser af klassen Regn som parameter og returnerer den samlede mængde af nedbør de to dage.

Se den vejledende løsning til 7.10 her.
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=c9d8e1b6-52d9-4bfe-bff5-ade5009f59f4
*/