import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'language'
})
export class LanguagePipe implements PipeTransform {

  dictionary = {
    pl: {
      languange: 'pl',
      values: {
        about: 'O mnie',
        skills: 'Umiejętnośći',
        projects: 'Projekty',
        home: 'START',
        contact: 'Kontakt',
        name: 'Przemysław Szymczuk',
        welcome: 'Witaj !',
        soft: `W Software Interactive Sp. z o.o. pracowałem jako młodszy programista angular,
         gdzie zbudowałem jeden większy projekt (190 zapytań) oraz jeden mniejszy i używałem przy nich min:`,
        softint: 'Software Interactive sp. z o.o.',
        szlips: `Pracowałem tutaj trzy lata i byłem odpowiedzialny z całe biuro,
         zespół składający się z dwóch osób i zawieranie umów ubezpieczeniowych - to tak w skrócie pisząc, a szczegóły poniżej:`,
        maur: `Była to moja pierwsza praca po zakończeniu studiów,
         pracowałem przez ponad trzy lata jako agent ubezpieczeniowy. Do moich obowiązków należało:`,
        polsl: 'Politechnikę ukończyłem w 2010 roku z wynikiem dobrym na wydziale Inżynierii Materiałowej i Metalurgii.',
        school: 'Politechnika Śląska w Katowicach',
        programmer: 'Młodszy programista Angular',
        assistant: `Asystent brokera`,
        broker: 'Ubezpieczeniowe Centrum Biznesu SZLIPS',
        agent: 'Agent ubezpieczeniowy',
        agency: 'Agencja ubezpieczeniowa MAUR',
        student: 'Zarządzanie i inżynieria produkcji',
        contactform: 'Formualrz kontaktowy',
        topicLabel: 'Temat',
        nameLabel: 'Nazwa',
        messageLabel: 'Wiadomość',
        mailText: 'przykładowy@mail.pl',
        contactformmore: '[ WIĘCEJ ]',
        welcomeText: 'Strona powstała w 2019 roku jako prezentacja umiejętności w Angular.',
        moreDialogTitle: 'kontakt',
        fieldRequired: 'Pole wymagane',
        wrongEmail: 'Błędny e-mail',
        send: 'Wyślij',
        sent: 'Wysłano pomyślnie',
        error: 'Nie wysłano, spróbój później'
      },
    },
    eng: {
      languange: 'eng',
      values: {
        about: 'About me',
        skills: 'Skills',
        projects: 'Projects',
        home: 'HOME',
        contact: 'Contact',
        name: 'Przemysław Szymczuk',
        welcome: 'Welcome !',
        soft: `In Software Interactive Sp. z .o.o i was a junior angular developer. I've made there
        one bigger (like for me) project with 190 request, and one smaller, and im using there:`,
        softint: 'Software Interactive sp. z o.o.',
        szlips: `I was work here as insurance agent for three years, and i was responsible
        for the office, two people team and makeing insurance documents. Writing in big short - details below:`,
        broker: `Insurance Center Of Buisness SZLIPS`,
        maur: `That was my first job after university, and i did not thinking it will be my job
        for longer time...I started here as insurance agent and I was responsible for:`,
        agency: 'Insurance agency MAUR',
        polsl: `I finished colledge in 2010 at department of Material Engineering and Metallurgy.`,
        school: ' Silesian University of Technology',
        programmer: 'Junior Angular developer',
        assistant: `Broker's assistant`,
        agent: 'Insurance agent',
        student: ' Management and Production Engineering',
        other: ['back', 'forward', 'backward', 'left'],
        contactform: 'Contact form',
        topicLabel: 'Topic',
        messageLabel: 'Message',
        nameLabel: 'Name',
        mailText: 'mail@example.com',
        contactformmore: '[ MORE ]',
        welcomeText: 'Site written in 2019 by Przemysław Szymczuk as Angular framework skills representation.',
        moreDialogTitle: 'more contact',
        fieldRequired: 'Field required',
        wrongEmail: 'Wrong e-mail',
        send: 'Send',
        sent: 'Mail sent',
        error: 'Error, try later'

      },
    }
  };

  transform(value: any, args?: any, arg?: any) {
    if (this.dictionary[value] != null && args != null) {
      return this.dictionary[value].values[args];
    }
  }
}
