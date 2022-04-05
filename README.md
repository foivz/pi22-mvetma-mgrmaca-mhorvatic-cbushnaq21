# Inicijalne upute za prijavu projekta iz Programskog inženjerstva

Poštovane kolegice i kolege, 

čestitamo vam jer ste uspješno prijavili svoj projektni tim na kolegiju Programsko inženjerstvo, te je za vas automatski kreiran repozitorij koji ćete koristiti za verzioniranje vašega koda, ali i za pisanje dokumentacije.

Ovaj dokument (README.md) predstavlja *osobnu iskaznicu vašeg projekta*. Vaš prvi zadatak, ukoliko niste odabrali da želite raditi na projektu sa nastavnicima ili u sklopu WBL-a je *prijaviti vlastiti projektni prijedlog* na način da ćete prijavu vašeg projekta, sukladno uputama danim u ovom tekstu, napisati upravo u ovaj dokument, umjesto ovoga teksta.

Za upute o sintaksi koju možete koristiti u ovom dokumentu i kod pisanje vaše projektne dokumentacije pogledajte [ovaj link](https://guides.github.com/features/mastering-markdown/).
Sav programski kod potrebno je verzionirati u glavnoj *master* grani i *obvezno* smjestiti u mapu Software. Sve artefakte (npr. slike) koje ćete koristiti u vašoj dokumentaciju obvezno verzionirati u posebnoj grani koja je već kreirana i koja se naziva *master-docs* i smjestiti u mapu Documentation.

# Vođenje evidencije u teretani

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG     | Github korisničko ime
------------  | ------------------- | --------- | ---------------------
Maja Horvatić | mhorvatic20@foi.hr  | 0016139285| mhorvatic20
Marko Grmača  | mgrmaca@foi.hr      | 0016137100| Marko128
Mislav Vetma  | mvetma@foi.hr       | 0016139285| Valsim99
Costa Bushnaq | cbushnaq21@foi.hr   | 0016157539| SpectreVert

## Opis domene
Ova aplikacija omogućit će djelatnicima teretana lakšu evidenciju korisnika. U aplikaciji će biti vidljivo tko su članovi, da li su uplatili članarinu, koju vrstu treninga su odabrali i slično. Jednako tako, olakšat će i korisnicima teretane uvid u plaćanje članarina, raspored treninga i slično. Dakle, kao što vidimo, aplikacija će biti dostupna i zaposlenicima teretane i njezinim korisnicima. Isto tako, aplikacija će omogućiti pregled rasporeda treninga što će korisnicima teretane dobro doći radi bolje organzacije vremena. Isto tako, aplikacije će omogućiti korisnicima lakši izbor trenera, jer će korisnici imati uvid o tome kada je neki trener slobodan, te će moći onda doći do njega. 

## Specifikacija projekta

No  | Feature       | Description | Responsible member
--- | ------------- | ----------- | ------------------
F01 | Login/sign up | Korisnik se za početak mora registrirat kako bi mogao u budućnosti koristiti aplikaciju, odnosno ulogirat se. | Marko Grmača
F02 | Članarina | Korisnik uz pomoć aplikacije vodi evidenciju o (ne)plaćenim članarinama | Mislav Vetma
F03 | Vrsta treninga | Korisnik u aplikaciji bira vrstu treninga (samostalni, individualni, grupni | Maja Horvatić
F04 | Raspored treninga | Korisnik ima uvid u raspored grupe treninga  | Marko Grmača
F05 | Profil trenera | Podaci o trenerima (općenito, kontakt)  | Mislav Vetma
F06 | Treneri | U ovom dijelu, svaki novi korisnik može odabrati svog osobnog trenera  |Maja Horvatić

## Tehnologije i oprema
U izradi programskih rješenja koristit će se tehnologije i alati koji se koriste na laboratorijskim vježbama kolegija.
