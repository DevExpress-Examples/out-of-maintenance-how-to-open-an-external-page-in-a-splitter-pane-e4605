@Code 
  ViewBag.Title = "NavBar"
End Code
@Html.DevExpress().Splitter(
    Sub(settings)
            settings.Name = "Splitter"
            settings.FullscreenMode = True
            settings.Height = System.Web.UI.WebControls.Unit.Percentage(100)
            settings.Width = System.Web.UI.WebControls.Unit.Percentage(100)
            settings.AllowResize = True
            settings.Panes.Add(
                Sub(pane)
                        pane.AutoWidth = True
                        pane.SetContent(
                            Sub()
                                    Html.DevExpress().NavBar(
                                        Sub(NavBarSettings)
                                                NavBarSettings.Name = "NavBar"
                                                NavBarSettings.Target = "NavigationIframe"
                                                NavBarSettings.Groups.Add(
                                                    Sub(group)
                                                            group.Text = "Navigation Group"

                                                            Dim item = group.Items.Add("Content 1")
                                                            item.NavigateUrl = Url.Action("Content1")

                                                            item = group.Items.Add("Content 2")
                                                            item.NavigateUrl = Url.Action("Content2")
                                                    End Sub)
                                        End Sub).Render()
                            End Sub)
                End Sub)
            settings.Panes.Add(
                Sub(pane)
                        pane.ContentUrl = "about:blank"
                        pane.ContentUrlIFrameName = "NavigationIframe"
                End Sub)
    End Sub).GetHtml()