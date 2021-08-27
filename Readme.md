<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128552702/13.2.11%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4605)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
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


