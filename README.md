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
F01 | Credentials | To begin with, the user must register in order to be able to use the application or log in in the future. | 
F01.A | Sign Up | User needs to create account for him to be able to use the app | Marko Grmača
F01.B | Login | Before he is able to use the app, user needs to login | Marko Grmača
F01.C | Password reset | User can request password reset | Marko Grmača
F02 | Membership fee | User pays gym membership fee every month | 
F02.A | Consult your due invoices | User gets to choose type of subscription | Mislav Vetma
F02.B | Generate + send PDF of invoice | The user receives the PDF via email about the paid invoice | Mislav Vetma
F03 | Training Managment | User can choose between training types and add them to the schedule | 
F03.A | Apply for training | User chooses training type | Maja Horvatić
F03.B | Choose timetable | User chooses appointment of training | Maja Horvatić
F03.C | Reminders | User can set reminders for his appointments | Maja Horvatić
F04 | User profiles | Types of user pfoiles available in the app | 
F04.A | Gym users | Users that come to train in the gym and their data | Costa Bushnaq
F04.B | Coach | Gym coaches and their data | Costa Bushnaq
F04.C | Gym Boss | Gym owner and admin | Costa Bushnaq

## Tehnologije i oprema
U izradi programskih rješenja koristit će se tehnologije i alati koji se koriste na laboratorijskim vježbama kolegija.
