<h3>Required Xamarin libraries:</h3>
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
<h3>Installation</h3>
<ol type="1">
<li>Clone repository</li>
<li>Save solution with three projects</li>
<li>Restore libraries "Restore nuget"</li>
<li>Build project</li>
</ol>
<h3>Troubleshooting</h3>
<p>In case of problem with resotoring libraries, you should delete this tag from *.cproj files in every project.</p> 
<p><b><xmp><Target Name="EnsureNuGetPackageBuildImports" BeforeTargets="PrepareForBuild">
</xmp></b>
  
