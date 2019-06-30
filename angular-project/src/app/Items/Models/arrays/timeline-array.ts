import * as infoType from './types';

export const timeline = [
    {
        dateFrom: new Date(2018, 9),
        dateTo: new Date(2019, 5),
        place: 'softint',
        content: 'Młodszy programista Angular',
        anchor: 'soft',
        job: 'programmer',
        pulse: 'first',
        type: infoType.infoType[0].experience,
    },
    {
        dateFrom: new Date(2014, 9),
        dateTo: new Date(2017, 8),
        place: 'broker',
        content: 'Agent ubezpieczeniowy',
        anchor: 'szlips',
        job: 'assistant',
        pulse: 'second',
        type: infoType.infoType[0].experience,
    },
    {
        dateFrom: new Date(2010, 11),
        dateTo: new Date(2014, 3),
        place: 'agency',
        content: 'Agent ubezpieczeniowy',
        anchor: 'maur',
        job: 'agent',
        pulse: 'third',
        type: infoType.infoType[0].experience,
    },
    {
        dateFrom: new Date(2005, 9),
        dateTo: new Date(2010, 11),
        place: 'school',
        content: 'Zarządzanie i inżynieria produkcji',
        anchor: 'polsl',
        job: 'student',
        pulse: 'fourth',
        type: infoType.infoType[0].education,
    }
];

