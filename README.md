
Za upute o sintaksi koju možete koristiti u ovom dokumentu i kod pisanje vaše projektne dokumentacije pogledajte [ovaj link](https://guides.github.com/features/mastering-markdown/).

# Gym record app

## Project team

Ime i prezime | E-mail adresa (FOI) | JMBAG     | Github korisničko ime
------------  | ------------------- | --------- | ---------------------
Maja Horvatić | mhorvatic20@foi.hr  | 0016139285| mhorvatic20
Marko Grmača  | mgrmaca@foi.hr      | 0016137100| Marko128
Mislav Vetma  | mvetma@foi.hr       | 0016139285| Valsim99
Costa Bushnaq | cbushnaq21@foi.hr   | 0016157539| SpectreVert

## Project description

This app will make it easier for gym staff to register users. The application will show who the members are, whether they have paid the membership fee, what type of training they have chosen and the like. Equally, it will make it easier for gym users to see the payment of membership fees, training schedule and the like. So, as we can see, the app will be available to both gym employees and its users. Also, the application will allow you to view the training schedule, which will be good for gym users for better organization of time. Also, the apps will make it easier for users to choose a coach, as users will have insight into when a coach is free and will be able to get to it then.



This application is made for gym users to make it easier to keep records. The world has been completely digitalized, so it would be time to digitize the management of the gym, which will make it easier to monitor the obligations of gym users, employees and the owner.
The user has the following options:

• Join the gym
The user can create their own account via the application, ie register, thus becoming a member of the gym. After the first registration, the user uses his account only for login.

• Pay membership fees
After the first registration, each user selects the subscription program and when paying for it receives an e-mail with a PDF document containing the invoice, and so every month. After the first unpaid bill, it is considered that the user is no longer a member of the gym.

• Choose the type of training
There are 3 types of training - individual (with a private trainer), group and individual. If the user chooses independent training, apart from the account, he will not need the application. However, if after a few months he decides on another type of training, the user can change this option.

• Individual trainings
Individual trainings are trainings with a private trainer. If the user selects this option, a list of all private trainers employed in that gym will open. Before choosing a coach, the user can read the details about that coach so he can choose the coach that suits him best.

• Group trainings
If the user decides for group training (because it is still easier to train in company), the schedule of group trainings opens. Given the daily obligations, according to this schedule, the user will best assess which terms of group training are most suitable for him and pre-register for these dates.

• Reminders
The app also has reminders! Users of this app can put a reminder for their training in the form of an alarm. So, the reminder can be set two days before, the day before, a few hours before the training, or whatever suits the user.

In addition to the user, this application makes it easier to keep track of obligations and coaches.
• Private trainings
Private training coaches can see which users have signed up for their training. After the user enrolls, the trainer will contact the user and send him his training schedule so that the user can book his appointment. In addition, the trainer will find it easier to keep track of which user has training and in the same schedule can make a training plan, or what each user trains that day (upper body, lower body, cardio…).

• Group trainings
With the help of this application, group training coaches can also keep records of which group training they have, what they will train that day and how many users have registered for that term.

• Just like users, trainers can also put training reminders

And finally, we come to the owner of the gym. The owner of the gym has an insight into the user profiles of all users, user profiles of all coaches, and with the help of this application he can see how his gym is progressing. Also, the owner of the gym in this way can more easily monitor the number of working hours of its employees (coaches) because it has insight into all schedules.




## Project specification

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
F03.A | Apply for training | User chooses training type group training or individual (with coach) | Maja Horvatić
F03.B | Choose timetable | User chooses appointment of training | Maja Horvatić
F03.C | Reminders and notifications | User can set reminders for his appointments, reminders are sent via e-mail. Also, the coach gets e-mail notification when client is trying to hire him. | Maja Horvatić
F04 | User profiles - Superadmin | Types of user pfoiles available in the app | 
F04.A | Gym users | Users that come to train in the gym and their data | Costa Bushnaq
F04.B | Coach | Gym coaches and their data | Costa Bushnaq
F04.C | Admin | Gym owner and admin | Costa Bushnaq
F05 | Statistics | Gym owner and admin has review of all relevant statistics for the gym (users, trainigs, presence ect.) | Costa Bushnaq   

## Technologies and equipment
The technologies and tools used in the laboratory exercises of the course will be used in the development of software solutions.
