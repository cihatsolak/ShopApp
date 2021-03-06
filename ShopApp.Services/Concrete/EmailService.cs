﻿using SendGrid;
using SendGrid.Helpers.Mail;
using ShopApp.Services.Abstract;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Services.Concrete
{
    public partial class EmailService : IEmailService
    {
        //send grid key -> send grid sitesinden aldığımız api key.
        private const string sendGridKey = "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";

        public Task SendEmailAsync(string email, string subject, string ApprovedUrl)
        {
           string htmlMessage = PrepareEmailHtmlTemplate(ApprovedUrl, subject);

            return Execute(sendGridKey, email, subject, htmlMessage);
        }

        private Task Execute(string sendGridKey, string email, string subject, string htmlMessage)
        {
            var client = new SendGridClient(sendGridKey);

            var message = new SendGridMessage()
            {
                From = new EmailAddress("info@shopapp.com.tr", "Shop App"),
                Subject = subject,
                PlainTextContent = htmlMessage,
                HtmlContent = htmlMessage
            };

            message.AddTo(new EmailAddress() { Email = email });
            return client.SendEmailAsync(message);
        }

        public string PrepareEmailHtmlTemplate(string ApprovedUrl, string subject)
        {
            //Create a new StringBuilder object
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("<!doctype html>");
            sb.AppendLine("<html>");
            sb.AppendLine("  <head>");
            sb.AppendLine("    <meta name=\"viewport\" content=\"width=device-width\" />");
            sb.AppendLine("    <meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\" />");
            sb.AppendLine("    <title>" + subject + "</title>");
            sb.AppendLine("    <style>");
            sb.AppendLine("      /* -------------------------------------");
            sb.AppendLine("          GLOBAL RESETS");
            sb.AppendLine("      ------------------------------------- */");
            sb.AppendLine("      body {");
            sb.AppendLine("        background-color: #f6f6f6;");
            sb.AppendLine("        font-family: sans-serif;");
            sb.AppendLine("        -webkit-font-smoothing: antialiased;");
            sb.AppendLine("        font-size: 14px;");
            sb.AppendLine("        line-height: 1.4;");
            sb.AppendLine("        margin: 0;");
            sb.AppendLine("        padding: 0;");
            sb.AppendLine("        -ms-text-size-adjust: 100%;");
            sb.AppendLine("        -webkit-text-size-adjust: 100%; }");
            sb.AppendLine("");
            sb.AppendLine("      table {");
            sb.AppendLine("        border-collapse: separate;");
            sb.AppendLine("        mso-table-lspace: 0pt;");
            sb.AppendLine("        mso-table-rspace: 0pt;");
            sb.AppendLine("        width: 100%; }");
            sb.AppendLine("        table td {");
            sb.AppendLine("          font-family: sans-serif;");
            sb.AppendLine("          font-size: 14px;");
            sb.AppendLine("          vertical-align: top; }");
            sb.AppendLine("");
            sb.AppendLine("      /* -------------------------------------");
            sb.AppendLine("          BODY & CONTAINER");
            sb.AppendLine("      ------------------------------------- */");
            sb.AppendLine("");
            sb.AppendLine("      .body {");
            sb.AppendLine("        background-color: #f6f6f6;");
            sb.AppendLine("        width: 100%; }");
            sb.AppendLine("");
            sb.AppendLine("      /* Set a max-width, and make it display as block so it will automatically stretch to that width, but will also shrink down on a phone or something */");
            sb.AppendLine("      .container {");
            sb.AppendLine("        display: block;");
            sb.AppendLine("        margin: 0 auto !important;");
            sb.AppendLine("        /* makes it centered */");
            sb.AppendLine("        max-width: 580px;");
            sb.AppendLine("        padding: 10px;");
            sb.AppendLine("        width: 580px; }");
            sb.AppendLine("");
            sb.AppendLine("      /* This should also be a block element, so that it will fill 100% of the .container */");
            sb.AppendLine("      .content {");
            sb.AppendLine("        box-sizing: border-box;");
            sb.AppendLine("        display: block;");
            sb.AppendLine("        margin: 0 auto;");
            sb.AppendLine("        max-width: 580px;");
            sb.AppendLine("        padding: 10px; }");
            sb.AppendLine("");
            sb.AppendLine("      /* -------------------------------------");
            sb.AppendLine("          HEADER, FOOTER, MAIN");
            sb.AppendLine("      ------------------------------------- */");
            sb.AppendLine("      .main {");
            sb.AppendLine("        background: #ffffff;");
            sb.AppendLine("        border-radius: 3px;");
            sb.AppendLine("        width: 100%; }");
            sb.AppendLine("");
            sb.AppendLine("      .wrapper {");
            sb.AppendLine("        box-sizing: border-box;");
            sb.AppendLine("        padding: 20px; }");
            sb.AppendLine("");
            sb.AppendLine("      .content-block {");
            sb.AppendLine("        padding-bottom: 10px;");
            sb.AppendLine("        padding-top: 10px;");
            sb.AppendLine("      }");
            sb.AppendLine("");
            sb.AppendLine("      /* -------------------------------------");
            sb.AppendLine("          TYPOGRAPHY");
            sb.AppendLine("      ------------------------------------- */");
            sb.AppendLine("     ");
            sb.AppendLine("      p,");
            sb.AppendLine("      ul,");
            sb.AppendLine("      ol {");
            sb.AppendLine("        font-family: sans-serif;");
            sb.AppendLine("        font-size: 14px;");
            sb.AppendLine("        font-weight: normal;");
            sb.AppendLine("        margin: 0;");
            sb.AppendLine("        margin-bottom: 15px; }");
            sb.AppendLine("        p li,");
            sb.AppendLine("        ul li,");
            sb.AppendLine("        ol li {");
            sb.AppendLine("          list-style-position: inside;");
            sb.AppendLine("          margin-left: 5px; }");
            sb.AppendLine("");
            sb.AppendLine("      a {");
            sb.AppendLine("        color: #3498db;");
            sb.AppendLine("        text-decoration: underline; }");
            sb.AppendLine("");
            sb.AppendLine("      /* -------------------------------------");
            sb.AppendLine("          BUTTONS");
            sb.AppendLine("      ------------------------------------- */");
            sb.AppendLine("      .btn {");
            sb.AppendLine("        box-sizing: border-box;");
            sb.AppendLine("        width: 100%; }");
            sb.AppendLine("        .btn > tbody > tr > td {");
            sb.AppendLine("          padding-bottom: 15px; }");
            sb.AppendLine("        .btn table {");
            sb.AppendLine("          width: auto; }");
            sb.AppendLine("        .btn table td {");
            sb.AppendLine("          background-color: #ffffff;");
            sb.AppendLine("          border-radius: 5px;");
            sb.AppendLine("          text-align: center; }");
            sb.AppendLine("        .btn a {");
            sb.AppendLine("          background-color: #ffffff;");
            sb.AppendLine("          border: solid 1px #3498db;");
            sb.AppendLine("          border-radius: 5px;");
            sb.AppendLine("          box-sizing: border-box;");
            sb.AppendLine("          color: #3498db;");
            sb.AppendLine("          cursor: pointer;");
            sb.AppendLine("          display: inline-block;");
            sb.AppendLine("          font-size: 14px;");
            sb.AppendLine("          font-weight: bold;");
            sb.AppendLine("          margin: 0;");
            sb.AppendLine("          padding: 7px 15px;");
            sb.AppendLine("          text-decoration: none;");
            sb.AppendLine("          text-transform: capitalize; }");
            sb.AppendLine("");
            sb.AppendLine("      .btn-primary table td {");
            sb.AppendLine("        background-color: #3498db; }");
            sb.AppendLine("");
            sb.AppendLine("      .btn-primary a {");
            sb.AppendLine("        background-color: #3498db;");
            sb.AppendLine("        border-color: #3498db;");
            sb.AppendLine("        color: #ffffff; }");
            sb.AppendLine("");
            sb.AppendLine("      /* -------------------------------------");
            sb.AppendLine("          OTHER STYLES THAT MIGHT BE USEFUL");
            sb.AppendLine("      ------------------------------------- */");
            sb.AppendLine("      .last {");
            sb.AppendLine("        margin-bottom: 0; }");
            sb.AppendLine("");
            sb.AppendLine("      .first {");
            sb.AppendLine("        margin-top: 0; }");
            sb.AppendLine("");
            sb.AppendLine("      .align-center {");
            sb.AppendLine("        text-align: center; }");
            sb.AppendLine("");
            sb.AppendLine("      .align-right {");
            sb.AppendLine("        text-align: right; }");
            sb.AppendLine("");
            sb.AppendLine("      .align-left {");
            sb.AppendLine("        text-align: left; }");
            sb.AppendLine("");
            sb.AppendLine("      .clear {");
            sb.AppendLine("        clear: both; }");
            sb.AppendLine("");
            sb.AppendLine("      .mt0 {");
            sb.AppendLine("        margin-top: 0; }");
            sb.AppendLine("");
            sb.AppendLine("      .mb0 {");
            sb.AppendLine("        margin-bottom: 0; }");
            sb.AppendLine("");
            sb.AppendLine("      .preheader {");
            sb.AppendLine("        color: transparent;");
            sb.AppendLine("        display: none;");
            sb.AppendLine("        height: 0;");
            sb.AppendLine("        max-height: 0;");
            sb.AppendLine("        max-width: 0;");
            sb.AppendLine("        opacity: 0;");
            sb.AppendLine("        overflow: hidden;");
            sb.AppendLine("        mso-hide: all;");
            sb.AppendLine("        visibility: hidden;");
            sb.AppendLine("        width: 0; }");
            sb.AppendLine("");
            sb.AppendLine("      .powered-by a {");
            sb.AppendLine("        text-decoration: none; }");
            sb.AppendLine("");
            sb.AppendLine("      hr {");
            sb.AppendLine("        border: 0;");
            sb.AppendLine("        border-bottom: 1px solid #f6f6f6;");
            sb.AppendLine("        Margin: 20px 0; }");
            sb.AppendLine("");
            sb.AppendLine("      /* -------------------------------------");
            sb.AppendLine("          RESPONSIVE AND MOBILE FRIENDLY STYLES");
            sb.AppendLine("      ------------------------------------- */");
            sb.AppendLine("      @media only screen and (max-width: 620px) {");
            sb.AppendLine("        table[class=body] h1 {");
            sb.AppendLine("          font-size: 28px !important;");
            sb.AppendLine("          margin-bottom: 10px !important; }");
            sb.AppendLine("        table[class=body] p,");
            sb.AppendLine("        table[class=body] ul,");
            sb.AppendLine("        table[class=body] ol,");
            sb.AppendLine("        table[class=body] td,");
            sb.AppendLine("        table[class=body] span,");
            sb.AppendLine("        table[class=body] a {");
            sb.AppendLine("          font-size: 16px !important; }");
            sb.AppendLine("        table[class=body] .wrapper,");
            sb.AppendLine("        table[class=body] .article {");
            sb.AppendLine("          padding: 10px !important; }");
            sb.AppendLine("        table[class=body] .content {");
            sb.AppendLine("          padding: 0 !important; }");
            sb.AppendLine("        table[class=body] .container {");
            sb.AppendLine("          padding: 0 !important;");
            sb.AppendLine("          width: 100% !important; }");
            sb.AppendLine("        table[class=body] .main {");
            sb.AppendLine("          border-left-width: 0 !important;");
            sb.AppendLine("          border-radius: 0 !important;");
            sb.AppendLine("          border-right-width: 0 !important; }");
            sb.AppendLine("        table[class=body] .btn table {");
            sb.AppendLine("          width: 100% !important; }");
            sb.AppendLine("        table[class=body] .btn a {");
            sb.AppendLine("          width: 100% !important; }");
            sb.AppendLine("        table[class=body] .img-responsive {");
            sb.AppendLine("          height: auto !important;");
            sb.AppendLine("          max-width: 100% !important;");
            sb.AppendLine("          width: auto !important; }}");
            sb.AppendLine("");
            sb.AppendLine("      /* -------------------------------------");
            sb.AppendLine("          PRESERVE THESE STYLES IN THE HEAD");
            sb.AppendLine("      ------------------------------------- */");
            sb.AppendLine("      @media all {");
            sb.AppendLine("        .ExternalClass {");
            sb.AppendLine("          width: 100%; }");
            sb.AppendLine("        .ExternalClass,");
            sb.AppendLine("        .ExternalClass p,");
            sb.AppendLine("        .ExternalClass span,");
            sb.AppendLine("        .ExternalClass font,");
            sb.AppendLine("        .ExternalClass td,");
            sb.AppendLine("        .ExternalClass div {");
            sb.AppendLine("          line-height: 100%; }");
            sb.AppendLine("        .apple-link a {");
            sb.AppendLine("          color: inherit !important;");
            sb.AppendLine("          font-family: inherit !important;");
            sb.AppendLine("          font-size: inherit !important;");
            sb.AppendLine("          font-weight: inherit !important;");
            sb.AppendLine("          line-height: inherit !important;");
            sb.AppendLine("          text-decoration: none !important; }");
            sb.AppendLine("        .btn-primary table td:hover {");
            sb.AppendLine("          background-color: #34495e !important; }");
            sb.AppendLine("        .btn-primary a:hover {");
            sb.AppendLine("          background-color: #34495e !important;");
            sb.AppendLine("          border-color: #34495e !important; } }");
            sb.AppendLine("");
            sb.AppendLine("    </style>");
            sb.AppendLine("  </head>");
            sb.AppendLine("  <body class=\"\">");
            sb.AppendLine("    <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"body\">");
            sb.AppendLine("      <tr>");
            sb.AppendLine("        <td>&nbsp;</td>");
            sb.AppendLine("        <td class=\"container\">");
            sb.AppendLine("          <div class=\"content\">");
            sb.AppendLine("");
            sb.AppendLine("            <!-- START CENTERED WHITE CONTAINER -->");
            sb.AppendLine("            <span class=\"preheader\">This is preheader text. Some clients will show this text as a preview.</span>");
            sb.AppendLine("            <table class=\"main\">");
            sb.AppendLine("");
            sb.AppendLine("              <!-- START MAIN CONTENT AREA -->");
            sb.AppendLine("              <tr>");
            sb.AppendLine("                <td class=\"wrapper\">");
            sb.AppendLine("                  <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\">");
            sb.AppendLine("                    <tr>");
            sb.AppendLine("                      <td>");
            sb.AppendLine("                        <p>Hoşgeldiniz,</p>");
            sb.AppendLine("                        <p>Yeni bir kullanıcı oluşturmanızla doğru bir karar verdiğinizden emin olabilirsiniz.Aşağıdaki butona tıklayarak hesabınızı hemen aktif edebilirsiniz.</p>");
            sb.AppendLine("                        <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"btn btn-primary\">");
            sb.AppendLine("                          <tbody>");
            sb.AppendLine("                            <tr>");
            sb.AppendLine("                              <td align=\"left\">");
            sb.AppendLine("                                <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\">");
            sb.AppendLine("                                  <tbody>");
            sb.AppendLine("                                    <tr>");
            sb.AppendLine("                                      <td> <a href=\"http://localhost:63062" + ApprovedUrl + "\" target=\"_blank\">Hesabımı Aktif Et</a></td>");
            sb.AppendLine("                                    </tr>");
            sb.AppendLine("                                  </tbody>");
            sb.AppendLine("                                </table>");
            sb.AppendLine("                              </td>");
            sb.AppendLine("                            </tr>");
            sb.AppendLine("                          </tbody>");
            sb.AppendLine("                        </table>");
            sb.AppendLine("                        <p>İyi Günler! Mutlu Alışverişler.</p>");
            sb.AppendLine("                      </td>");
            sb.AppendLine("                    </tr>");
            sb.AppendLine("                  </table>");
            sb.AppendLine("                </td>");
            sb.AppendLine("              </tr>");
            sb.AppendLine("");
            sb.AppendLine("            <!-- END MAIN CONTENT AREA -->");
            sb.AppendLine("            </table>");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("          <!-- END CENTERED WHITE CONTAINER -->");
            sb.AppendLine("          </div>");
            sb.AppendLine("        </td>");
            sb.AppendLine("        <td>&nbsp;</td>");
            sb.AppendLine("      </tr>");
            sb.AppendLine("    </table>");
            sb.AppendLine("");
            sb.AppendLine("  </body>");
            sb.AppendLine("</html>");

            return sb.ToString();

        }
    }
}
