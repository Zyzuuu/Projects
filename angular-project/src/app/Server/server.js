"use strict";
const nodemailer = require("nodemailer");
const express = require('express');
const bodyParser = require('body-parser');
var cors = require('cors');

const response = (result, err) => {
    const response = {
        sendResult: result,
        error: err
    }
    return response;
}

const app = express();
app.use(cors())
app.use(bodyParser.urlencoded({
    extended: true
}));
app.use(bodyParser.json());
app.post('/send_mail', (req, res) => {
    if (req.body.subject && req.body.mail && req.body.name && req.body.message) {
        main(req.body.subject, req.body.mail, req.body.name, req.body.message).then((result) => {
            res.send(response(result, 0));
        }).catch((error) => {
            res.send(response(error, 2));
        });
    } else {
        return res.send(1);
    }

});


app.listen(8080, () => console.log(`Server is listening on port: 8080`));
async function main(subject, mail, name, message) {

    let transporter = nodemailer.createTransport({
        host: "smtp.gmail.com",
        port: 587,
        secure: false,
        auth: {
            user: 'przemek.szymczuk@gmail.com',
            pass: 'apokalipsa123'
        }
    });

    await transporter.sendMail({
        from: '"Recrutation from site" <przemek.szymczuk@gmail.com>',
        to: "przemek.szymczuk@gmail.com",
        subject: `${subject}`, // Subject line
        text: null, // plain text body
        html:
            `
    <div style="width: 100%; height: 100%">
        <div
            style="position: relative; min-height: 50vh; width: 50vw; margin: 0 auto;  border: 1px dotted black; box-sizing: border-box">
            <div style="background-color: black; width: 100%; min-height: 100px">
                <table style="text-align: left;padding: 20px; font-size: 1vw; color: white; margin-bottom: 20px;">
                    <tr>
                        <th>Subject: </th>
                        <td style="padding-left: 20px">${subject}</td>
                    </tr>
                    <tr>
                        <th>Sender: </th>
                        <td style="padding-left: 20px">${name}</td>
                    </tr>
                    <tr>
                        <th>Mail: </th>
                        <td style="padding-left: 20px">${mail}</td>
                    </tr>
                </table>
            </div>
            <div style="width: 100%; min-height: 30%; margin-top: 20px;">
                <table style="text-align: left;padding: 20px; font-size: 1vw; margin-bottom: 20px;">
                    <tr>
                        <th>Message: </th>
                    </tr>
                    <tr>
                        <td style="padding-left: 20px">${message}</td>
                    </tr>
                </table>
            </div>
            <p style="float: right; margin-right: 20px">[Sent from nodemailer server]</p>
        </div>
    </div>
        `
    });
}

