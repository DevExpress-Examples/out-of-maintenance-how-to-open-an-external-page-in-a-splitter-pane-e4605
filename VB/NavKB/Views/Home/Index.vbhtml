<center>
    <table>
        <tr>
            <td>
                @Html.DevExpress().Button(Sub(settings)
                                              settings.Name = "ButtonNavBar"
                                              settings.UseSubmitBehavior = False
                                              settings.RouteValues = New With {.Controller = "Home", .Action = "NavBar"}
                                              settings.Text = "NavBar example"
                                          End Sub).GetHtml()
            </td>
            <td>
                @Html.DevExpress().Button(Sub(settings)
                                              settings.Name = "ButtonMenu"
                                              settings.UseSubmitBehavior = False
                                              settings.RouteValues = New With {.Controller = "Home", .Action = "Menu"}
                                              settings.Text = "Menu example"
                                          End Sub).GetHtml()
            </td>
            <td>
                @Html.DevExpress().Button(Sub(settings)
                                              settings.Name = "ButtonTreeView"
                                              settings.UseSubmitBehavior = False
                                              settings.RouteValues = New With {.Controller = "Home", .Action = "TreeView"}
                                              settings.Text = "TreeView example"
                                          End Sub).GetHtml()
            </td>
        </tr>
    </table>
</center>