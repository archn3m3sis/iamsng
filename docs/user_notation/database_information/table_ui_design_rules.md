#tables #design #ui #iams #ispr 

:FasIndustry: `iams` - industrial asset management system

:LiTerminalSquare: `itaps` - industrial terminal api plugin solution

:LiChartNoAxesCombined: `ispir` - industrial security posture integrity rating 

:FasMagnifyingGlassChart: `rave` - reoccuring audit verification edifier  

:BoBxsCollection: `iack` - industrial asset collection kit 	

:TiShieldCheckered: `iads` - industrial asset defense system 

:TiAlertSquareRounded: `inteliavm` - iams solution to providing near real time intelligence for air gapped industrial assets...

###### retrieve an edifier report for the entire ifmc program...
```http
GET edifier.report FOR ifmc.[ all | asset_name | top10 | bot10 ]
```
###### To retrieve fleetwide reporting enter the one line api call below...vg
```http
GET edifier.report FOR ifamc+tagm+storm+shield+multi+stare.all
```

```http | iams
GET edifier.report FOR ifmc.all     
```






#### TABLE CONCEPTS FOR IAMS
---
responsive_table
![[Pasted image 20250928203350.png]]


```css
@charset "UTF-8";
@import url(https://fonts.googleapis.com/css?family=Open+Sans:300,400,700);

body {
  font-family: 'Open Sans', sans-serif;
  font-weight: 300;
  line-height: 1.42em;
  color:#A7A1AE;
  background-color:#1F2739;
}

h1 {
  font-size:3em; 
  font-weight: 300;
  line-height:1em;
  text-align: center;
  color: #4DC3FA;
}

h2 {
  font-size:1em; 
  font-weight: 300;
  text-align: center;
  display: block;
  line-height:1em;
  padding-bottom: 2em;
  color: #FB667A;
}

h2 a {
  font-weight: 700;
  text-transform: uppercase;
  color: #FB667A;
  text-decoration: none;
}

.blue { color: #185875; }
.yellow { color: #FFF842; }

.container th h1 {
    font-weight: bold;
    font-size: 1em;
  text-align: left;
  color: #185875;
}

.container td {
    font-weight: normal;
    font-size: 1em;
  -webkit-box-shadow: 0 2px 2px -2px #0E1119;
     -moz-box-shadow: 0 2px 2px -2px #0E1119;
          box-shadow: 0 2px 2px -2px #0E1119;
}

.container {
    text-align: left;
    overflow: hidden;
    width: 80%;
    margin: 0 auto;
  display: table;
  padding: 0 0 8em 0;
}

.container td, .container th {
    padding-bottom: 2%;
    padding-top: 2%;
  padding-left:2%;  
}

/* Background-color of the odd rows */
.container tr:nth-child(odd) {
    background-color: #323C50;
}

/* Background-color of the even rows */
.container tr:nth-child(even) {
    background-color: #2C3446;
}

.container th {
    background-color: #1F2739;
}

.container td:first-child { color: #FB667A; }

.container tr:hover {
   background-color: #464A52;
-webkit-box-shadow: 0 6px 6px -6px #0E1119;
     -moz-box-shadow: 0 6px 6px -6px #0E1119;
          box-shadow: 0 6px 6px -6px #0E1119;
}

.container td:hover {
  background-color: #FFF842;
  color: #403E10;
  font-weight: bold;
  
  box-shadow: #7F7C21 -1px 1px, #7F7C21 -2px 2px, #7F7C21 -3px 3px, #7F7C21 -4px 4px, #7F7C21 -5px 5px, #7F7C21 -6px 6px;
  transform: translate3d(6px, -6px, 0);
  
  transition-delay: 0s;
    transition-duration: 0.4s;
    transition-property: all;
  transition-timing-function: line;
}

@media (max-width: 800px) {
.container td:nth-child(4),
.container th:nth-child(4) { display: none; }
}

```

```html
<h1><span class="blue">&lt;</span>Table<span class="blue">&gt;</span> <span class="yellow">Responsive</pan></h1>
<h2>Created with love by <a href="https://github.com/pablorgarcia" target="_blank">Pablo García</a></h2>

<table class="container">
  <thead>
    <tr>
      <th><h1>Sites</h1></th>
      <th><h1>Views</h1></th>
      <th><h1>Clicks</h1></th>
      <th><h1>Average</h1></th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>Google</td>
      <td>9518</td>
      <td>6369</td>
      <td>01:32:50</td>
    </tr>
    <tr>
      <td>Twitter</td>
      <td>7326</td>
      <td>10437</td>
      <td>00:51:22</td>
    </tr>
    <tr>
      <td>Amazon</td>
      <td>4162</td>
      <td>5327</td>
      <td>00:24:34</td>
    </tr>
    <tr>
      <td>LinkedIn</td>
      <td>3654</td>
      <td>2961</td>
      <td>00:12:10</td>
    </tr>
    <tr>
      <td>CodePen</td>
      <td>2002</td>
      <td>4135</td>
      <td>00:46:19</td>
    </tr>
    <tr>
      <td>GitHub</td>
      <td>4623</td>
      <td>3486</td>
      <td>00:31:52</td>
    </tr>
  </tbody>
</table>
```


### fade and blur hover table
```html
<table>
  <thead>
    <tr>
      <th>Option</th>
      <th>Default</th>
      <th>Description</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td><strong>showSpeed</strong></td>
      <td>15</td>
      <td>The speed of the show/reveal</td>
    </tr>
    <tr>
      <td><strong>showEasing</strong></td>
      <td>'linear'</td>
      <td>The easing of the show/reveal</td>
    </tr>
    <tr>
      <td><strong>hideSpeed</strong></td>
      <td>50</td>
      <td>The speed of the hide/conceal</td>
    </tr>
    <tr>
      <td><strong>hideEasing</strong></td>
      <td>'linear'</td>
      <td>The easing of the hide/conceal</td>
    </tr>         
    <tr>
      <td><strong>width</strong></td>
      <td>'auto'</td>
      <td>The width that the data will be truncated to - <em>('auto' or px amount)</em></td>
    </tr>
    <tr>
      <td><strong>ellipsis</strong></td>
      <td>true</td>
      <td>Set to true to enable the ellipsis</td>
    </tr>
    <tr>
      <td><strong>title</strong></td>
      <td>false</td>
      <td>Set to true to show the full data on hover</td>
    </tr>
    <tr>
      <td><strong>afterShow</strong></td>
      <td> $.noop</td>
      <td>The callback fired after the show/reveal</td>
    </tr>
    <tr>
      <td><strong>afterHide</strong></td>
      <td>$.noop</td>
      <td>The callback fired after the hide/conceal</td>
    </tr>
  </tbody>
</table>
```

```CSS
body {
  background: #fafafa url(https://jackrugile.com/images/misc/noise-diagonal.png);
  color: #444;
  font: 100%/30px 'Helvetica Neue', helvetica, arial, sans-serif;
  text-shadow: 0 1px 0 #fff;
}

strong {
  font-weight: bold; 
}

em {
  font-style: italic; 
}

table {
  background: #f5f5f5;
  border-collapse: separate;
  box-shadow: inset 0 1px 0 #fff;
  font-size: 12px;
  line-height: 24px;
  margin: 30px auto;
  text-align: left;
  width: 800px;
} 

th {
  background: url(https://jackrugile.com/images/misc/noise-diagonal.png), linear-gradient(#777, #444);
  border-left: 1px solid #555;
  border-right: 1px solid #777;
  border-top: 1px solid #555;
  border-bottom: 1px solid #333;
  box-shadow: inset 0 1px 0 #999;
  color: #fff;
  font-weight: bold;
  padding: 10px 15px;
  position: relative;
  text-shadow: 0 1px 0 #000;  
}

th:after {
  background: linear-gradient(rgba(255,255,255,0), rgba(255,255,255,.08));
  content: '';
  display: block;
  height: 25%;
  left: 0;
  margin: 1px 0 0 0;
  position: absolute;
  top: 25%;
  width: 100%;
}

th:first-child {
  border-left: 1px solid #777;  
  box-shadow: inset 1px 1px 0 #999;
}

th:last-child {
  box-shadow: inset -1px 1px 0 #999;
}

td {
  border-right: 1px solid #fff;
  border-left: 1px solid #e8e8e8;
  border-top: 1px solid #fff;
  border-bottom: 1px solid #e8e8e8;
  padding: 10px 15px;
  position: relative;
  transition: all 300ms;
}

td:first-child {
  box-shadow: inset 1px 0 0 #fff;
} 

td:last-child {
  border-right: 1px solid #e8e8e8;
  box-shadow: inset -1px 0 0 #fff;
} 

tr {
  background: url(https://jackrugile.com/images/misc/noise-diagonal.png); 
}

tr:nth-child(odd) td {
  background: #f1f1f1 url(https://jackrugile.com/images/misc/noise-diagonal.png); 
}

tr:last-of-type td {
  box-shadow: inset 0 -1px 0 #fff; 
}

tr:last-of-type td:first-child {
  box-shadow: inset 1px -1px 0 #fff;
} 

tr:last-of-type td:last-child {
  box-shadow: inset -1px -1px 0 #fff;
} 

tbody:hover td {
  color: transparent;
  text-shadow: 0 0 3px #aaa;
}

tbody:hover tr:hover td {
  color: #444;
  text-shadow: 0 1px 0 #fff;
}
```


### responsive and accessible table
```html
<div class="container">
  <table class="responsive-table">
    <caption>Top 10 Grossing Animated Films of All Time</caption>
    <thead>
      <tr>
        <th scope="col">Film Title</th>
        <th scope="col">Released</th>
        <th scope="col">Studio</th>
        <th scope="col">Worldwide Gross</th>
        <th scope="col">Domestic Gross</th>
        <th scope="col">International Gross</th>
        <th scope="col">Budget</th>
      </tr>
    </thead>
    <tfoot>
      <tr>
        <td colspan="7">Sources: <a href="http://en.wikipedia.org/wiki/List_of_highest-grossing_animated_films" rel="external">Wikipedia</a> &amp; <a href="http://www.boxofficemojo.com/genres/chart/?id=animation.htm" rel="external">Box Office Mojo</a>. Data is current as of January 17, 2025.</td>
      </tr>
    </tfoot>
    <tbody>
      <tr>
        <th scope="row">Inside Out 2</th>
        <td data-title="Released">2024</td>
        <td data-title="Studio">Disney Pixar</td>
        <td data-title="Worldwide Gross" data-type="currency">$1,698,863,816</td>
        <td data-title="Domestic Gross" data-type="currency">$652,980,194</td>
        <td data-title="International Gross" data-type="currency">$1,045,883,622</td>
        <td data-title="Budget" data-type="currency">$200,000,000</td>
      </tr>
      <tr>
        <th scope="row">The Lion King (2019 remake)</th>
        <td data-title="Released">2019</td>
        <td data-title="Studio">Disney</td>
        <td data-title="Worldwide Gross" data-type="currency">$1,662,020,819</td>
        <td data-title="Domestic Gross" data-type="currency">$543,638,043</td>
        <td data-title="International Gross" data-type="currency">$1,118,382,776</td>
        <td data-title="Budget" data-type="currency">$260,000,000</td>
      </tr>
      <tr>
        <th scope="row">Frozen II</th>
        <td data-title="Released">2019</td>
        <td data-title="Studio">Disney</td>
        <td data-title="Worldwide Gross" data-type="currency">$1,453,683,476</td>
        <td data-title="Domestic Gross" data-type="currency">$477,373,578</td>
        <td data-title="International Gross" data-type="currency">$976,309,898</td>
        <td data-title="Budget" data-type="currency">$150,000,000</td>
      </tr>
       <tr>
        <th scope="row">The Super Mario Bros. Movie</th>
        <td data-title="Released">2023</td>
        <td data-title="Studio">Universal</td>
        <td data-title="Worldwide Gross" data-type="currency">$1,360,847,665</td>
        <td data-title="Domestic Gross" data-type="currency">$574,934,330</td>
        <td data-title="International Gross" data-type="currency">$785,913,335</td>
        <td data-title="Budget" data-type="currency">$100,000,000</td>
      </tr>
      <tr>
        <th scope="row">Frozen</th>
        <td data-title="Released">2013</td>
        <td data-title="Studio">Disney</td>
        <td data-title="Worldwide Gross" data-type="currency">$1,281,019,275</td>
        <td data-title="Domestic Gross" data-type="currency">$400,953,009</td>
        <td data-title="International Gross" data-type="currency">$880,066,266</td>
        <td data-title="Budget" data-type="currency">$150,000,000</td>
      </tr>
       <tr>
        <th scope="row">Incredibles 2</th>
        <td data-title="Released">2018</td>
        <td data-title="Studio">Disney Pixar</td>
        <td data-title="Worldwide Gross" data-type="currency">$1,243,089,244</td>
        <td data-title="Domestic Gross" data-type="currency">$608,581,744</td>
        <td data-title="International Gross" data-type="currency">$634,507,500</td>
        <td data-title="Budget" data-type="currency">$200,000,000</td>
      </tr>
      <tr>
        <th scope="row">Minions</th>
        <td data-title="Released">2015</td>
        <td data-title="Studio">Universal</td>
        <td data-title="Worldwide Gross" data-type="currency">$1,159,444,662</td>
        <td data-title="Domestic Gross" data-type="currency">$336,045,770</td>
        <td data-title="International Gross" data-type="currency">$823,398,892</td>
        <td data-title="Budget" data-type="currency">$74,000,000</td>
      </tr>
      <tr>
        <th scope="row">Toy Story 4</th>
        <td data-title="Released">2019</td>
        <td data-title="Studio">Disney Pixar</td>
        <td data-title="Worldwide Gross" data-type="currency">$1,073,394,593</td>
        <td data-title="Domestic Gross" data-type="currency">$434,038,008</td>
        <td data-title="International Gross" data-type="currency">$639,356,585</td>
        <td data-title="Budget" data-type="currency">$200,000,000</td>
      </tr>
      <tr>
        <th scope="row">Toy Story 3</th>
        <td data-title="Released">2010</td>
        <td data-title="Studio">Disney Pixar</td>
        <td data-title="Worldwide Gross" data-type="currency">$1,066,970,811</td>
        <td data-title="Domestic Gross" data-type="currency">$415,004,880</td>
        <td data-title="International Gross" data-type="currency">$651,965,931</td>
        <td data-title="Budget" data-type="currency">$200,000,000</td>
      </tr>
      <tr>
        <th scope="row">Despicable Me 3</th>
        <td data-title="Released">2017</td>
        <td data-title="Studio">Universal</td>
        <td data-title="Worldwide Gross" data-type="currency">$1,034,800,131</td>
        <td data-title="Domestic Gross" data-type="currency">$264,624,300</td>
        <td data-title="International Gross" data-type="currency">$770,175,831</td>
        <td data-title="Budget" data-type="currency">$80,000,000</td>
      </tr>
    </tbody>
  </table>
</div>
```


```scss
@import "bourbon@5.*";

// Breakpoints
$bp-maggie: 15em; 
$bp-lisa: 30em;
$bp-bart: 48em;
$bp-marge: 62em;
$bp-homer: 75em;

// Styles
html {
  box-sizing: border-box;
}

*,
*:before,
*:after {
  box-sizing: inherit;
}

body {
  font-family: $font-stack-system;
  color: rgba(0,0,0,.87);
}

a {
  color: rgba(38,137,13,1);
  
  &:hover,
  &:focus {
    color: rgba(4,106,56,1); 
  }
}

.container {
  margin: 5% 3%;
  
  @media (min-width: $bp-bart) {
    margin: 2%; 
  }
  
  @media (min-width: $bp-homer) {
    margin: 2em auto;
    max-width: $bp-homer;
  }
}

.responsive-table {
  width: 100%;
  margin-bottom: 1.5em;
  border-spacing: 0;
  
  @media (min-width: $bp-bart) {
    font-size: .9em; 
  }
  
  @media (min-width: $bp-marge) {
    font-size: 1em; 
  }
  
  thead {
    // Accessibly hide <thead> on narrow viewports
    position: absolute;
    clip: rect(1px 1px 1px 1px); /* IE6, IE7 */
    padding: 0;
    border: 0;
    height: 1px; 
    width: 1px; 
    overflow: hidden;
    
    @media (min-width: $bp-bart) {
      // Unhide <thead> on wide viewports
      position: relative;
      clip: auto;
      height: auto;
      width: auto;
      overflow: auto;
    }
    
    th {
      background-color: rgba(38,137,13,1);
      border: 1px solid rgba(134,188,37,1);
      font-weight: normal;
      text-align: center;
      color: white;
      
      &:first-of-type {
        text-align: left; 
      }
    }
  }
  
  // Set these items to display: block for narrow viewports
  tbody,
  tr,
  th,
  td {
    display: block;
    padding: 0;
    text-align: left;
    white-space: normal;
  }
  
  tr {   
    @media (min-width: $bp-bart) {
      // Undo display: block 
      display: table-row; 
    }
  }
  
  th,
  td {
    padding: .5em;
    vertical-align: middle;
    
    @media (min-width: $bp-lisa) {
      padding: .75em .5em; 
    }
    
    @media (min-width: $bp-bart) {
      // Undo display: block 
      display: table-cell;
      padding: .5em;
    }
    
    @media (min-width: $bp-marge) {
      padding: .75em .5em; 
    }
    
    @media (min-width: $bp-homer) {
      padding: .75em; 
    }
  }
  
  caption {
    margin-bottom: 1em;
    font-size: 1em;
    font-weight: bold;
    text-align: center;
    
    @media (min-width: $bp-bart) {
      font-size: 1.5em;
    }
  }
  
  tfoot {
    font-size: .8em;
    font-style: italic;
    
    @media (min-width: $bp-marge) {
      font-size: .9em;
    }
  }
  
  tbody {
    @media (min-width: $bp-bart) {
      // Undo display: block 
      display: table-row-group; 
    }
    
    tr {
      margin-bottom: 1em;
      
      @media (min-width: $bp-bart) {
        // Undo display: block 
        display: table-row;
        border-width: 1px;
      }
      
      &:last-of-type {
        margin-bottom: 0; 
      }
      
      &:nth-of-type(even) {
        @media (min-width: $bp-bart) {
          background-color: rgba(0,0,0,.12);
        }
      }
    }
    
    th[scope="row"] {
      background-color: rgba(38,137,13,1);
      color: white;
      
      @media (min-width: $bp-lisa) {
        border-left: 1px solid rgba(134,188,37,1);
        border-bottom: 1px solid rgba(134,188,37,1);
      }
      
      @media (min-width: $bp-bart) {
        background-color: transparent;
        color: rgba(0,0,0.87);
        text-align: left;
      }
    }
    
    td {
      text-align: right;
      
      @media (min-width: $bp-bart) {
        border-left: 1px solid rgba(134,188,37,1);
        border-bottom: 1px solid rgba(134,188,37,1);
        text-align: center; 
      }
      
      &:last-of-type {
        @media (min-width: $bp-bart) {
          border-right: 1px solid rgba(134,188,37,1);
        } 
      }
    }
    
    td[data-type=currency] {
      text-align: right; 
    }
    
    td[data-title]:before {
      content: attr(data-title);
      float: left;
      font-size: .8em;
      color: rgba(0,0,0,.54);
      
      @media (min-width: $bp-lisa) {
        font-size: .9em; 
      }
      
      @media (min-width: $bp-bart) {
        // Don’t show data-title labels 
        content: none; 
      }
    } 
  }
}
```


### hyper focus raised table
![[Pasted image 20250928204312.png]]
```html
<h1>Race Times</h1>

<table id="racetimes">
<tr id="firstrow"><th>Race</th><th>Location</th><th>Distance (in kilometres)</th><th>Time</th></tr>
<tr><td>SAIT Open</td><td>Calgary</td><td>5</td><td></td></tr>
<tr><td>CALTAF Classic</td><td>Calgary</td><td>1.5</td><td>5.00</td></tr>
<tr><td>Calgary Marathon</td><td>Calgary</td><td>21.1</td><td>2:00.00</td></tr>
<tr><td>Zombie Survivor</td><td>Cochrane</td><td>5</td><td>25.00</td></tr>
<tr><td>Run for Women</td><td>Calgary</td><td>5</td><td>20.00</td></tr>
<tr><td>Mother's Day Run</td><td>Calgary</td><td>10</td><td>45.00</td></tr>
<tr><td>Edmonton Marathon</td><td>Edmonton</td><td>21.1</td><td>1:30.00</td></tr>
</table>
```

```css
* {font-family: Helvetica Neue, Arial, sans-serif; }

body { background-image: linear-gradient(#aaa 25%, #000);}

h1, table { text-align: center; }

table {border-collapse: collapse;  width: 70%; margin: 0 auto 5rem;}
				324175689eq0w=-rtyy5RWWWQ6T78Y900A0098077777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777776-------------------------------------------------------------------------------------------------------------------------555555555555555555555555Q12
th, td { padding: 1.5rem; font-size: 1.3rem; }

tr {background: hsl(50, 50%, 80%); }

tr, td { transition: .4s ease-in; } 

tr:first-child {background: hsla(12, 100%, 40%, 0.5); }

tr:nth-child(even) { background: hsla(50, 50%, 80%, 0.7); }

td:empty {background: hsla(50, 25%, 60%, 0.7); }

tr:hover:not(#firstrow), tr:hover td:empty {background: #ff0; pointer-events: visible;}
tr:hover:not(#firstrow) { transform: scale(1.2); font-weight: 700; box-shadow: 0px 3px 7px rgba(0, 0, 0, 0.5);}
```



![[Pasted image 20250928205447.png]]

![[Pasted image 20250928205512.png]]

			  786594YR=E-W3U2QA2=QAUwaq8qy82388231111111119999999999798463w2q5=e10-rtrtrtrtrrrrrrrrtry=97=89