<h3>Wymagane wersje bibliotek Xamarin:</h3>
<ul>
<li>Xamarin.Forms: 2.0.0.6482</li>
<li>Xamarin.Android.Support.Animated.Vector.Drawable 23.3.0</li>
<li>Xamarin.Android.Support.Design 23.0.1.3</li>
<li>Xamarin.Android.Support.v4 23.0.1.3</li>
<li>Xamarin.Android.Support.v7.AppCompat 23.0.1.3</li>
<li>Xamarin.Android.Support.v7.CardView 23.0.1.3</li>
<li>Xamarin.Android.Support.v7.MediaRouter 23.0.1.3</li>
<li>Xamarin.Android.Support.v7.RecyclerView 23.0.1.3</li>
<li>Xamarin.Android.Support.Vector.Drawable 23.3.0</li>
</ul>
<h3>Instalacja</h3>
<ol type="1">
<li>Sklonowac repozyotrium</li>
<li>Zapisać solucję z trzema projektami</li>
<li>Przywrócić biblioteki "Restore nuget"</li>
<li>Zbudować projekty</li>
</ol>
<h3>Troubleshooting</h3>
<p>W przypadku błędu z przywróceniem bibliotek usunąć cały element</p> 
<p><b><xmp><Target Name="BeforeBuild"></xmp></b> z plików *.cproj dla każdego z projektów.</p>
  
