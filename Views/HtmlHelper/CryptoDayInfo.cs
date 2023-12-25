using Microsoft.AspNetCore.Html;
using WebNet3.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebNet3.Views.HtmlHelper
{
    public static class CryptoDayInfo
    {
        public static IHtmlContent CryptoDay(this IHtmlHelper html, Ada ada)
        {
            var content = new HtmlContentBuilder();

            content.AppendHtml($"<div style=\"color: black;\"><b>Ticker&nbsp:&nbsp</b> {ada.ticker}</div>");
            content.AppendHtml($"<div style=\"color: black;\"><b>Date&nbsp;&nbsp;&nbsp;:&nbsp;</b>{ada.date}</div>");
            content.AppendHtml($"<div style=\"color: black;\"><b>Open&nbsp;&nbsp;:&nbsp;</b>{ada.open}</div>");
            content.AppendHtml($"<div style=\"color: black;\"><b>High&nbsp;&nbsp;&nbsp;:&nbsp;</b>{ada.high}</div>");
            content.AppendHtml($"<div style=\"color: black;\"><b>Low&nbsp;&nbsp;&nbsp;&nbsp;:&nbsp;</b>{ada.low} </div>");
            content.AppendHtml($"<div style=\"color: black;\"><b>Close&nbsp;&nbsp;:&nbsp;</b>{ada.close}</div>");

            return content;
        }
    }
}