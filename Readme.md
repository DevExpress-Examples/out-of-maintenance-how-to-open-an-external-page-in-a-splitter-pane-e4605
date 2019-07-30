<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/NavKB/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/NavKB/Controllers/HomeController.vb))
* [Index.cshtml](./CS/NavKB/Views/Home/Index.cshtml)
* [Menu.cshtml](./CS/NavKB/Views/Home/Menu.cshtml)
* [NavBar.cshtml](./CS/NavKB/Views/Home/NavBar.cshtml)
* [TreeView.cshtml](./CS/NavKB/Views/Home/TreeView.cshtml)
* [ContentPage1.cshtml](./CS/NavKB/Views/Shared/ContentPage1.cshtml)
* [ContentPage2.cshtml](./CS/NavKB/Views/Shared/ContentPage2.cshtml)
<!-- default file list end -->
# How to open an external Page in a Splitter Pane
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4605/)**
<!-- run online end -->


<p>This example is an illustration of the <a href="https://www.devexpress.com/Support/Center/p/KA18732">KA18732: How to open external Page / View in a Splitter Pane</a> KB Article. Refer to the Article for an explanation.<br /> It demonstrates how to open an external Page in a Splitter Pane using navigation extensions.</p>
<br />
<p>Set the pane's ContentUrl property to "about:blank". This will render the pane as an iframe.</p>
<p>In addition, set the pane's ContentUrlIFrameName property. This will be the target to open links from the navigation extensions items. Thus, any item's Target property should be equal to the pane's ContentUrlIFrameName property.</p>
<br />
<p>pane.ContentUrl = "about:blank";</p>
<p>pane.ContentUrlIFrameName = "NavigationIframe";</p>
<br />
<p>Different approaches can be used to set the Target property:<br />- Item level;</p>
<p>- Extension level;</p>
<p>- Datasource level.</p>

<br/>


