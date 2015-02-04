<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="TwilioWebAPP_SMS._default" %>



  <div>
                <form>
                <h4>Number</h4>
                <input type="text" ID="ToNumberr" TextMode="Password" runat="server" />
                 <h4>Message</h4>
                <input type="text" ID="Messagetxt"  runat="server" />
                <br />
                <br />
                <button type="submit"  OnClick="SendMessage_OnClick" />
                   </form>
            </div>




