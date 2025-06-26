import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
// You must import any component you use i this component 
// import for external component - may be automatically added by IDE
import { FormExampleComponent } from './components/form-example/form-example.component';
// @Component identifies all the Angular stuff you are using
//            including new components
@Component({
  selector: 'app-root', //isnt the name of the tag used in html to reference the component
  standalone: true,
  // imports identifies external resources, like components, used in the app
  imports: [RouterOutlet, FormExampleComponent],  // Note the import name has Component
  templateUrl: './app.component.html',       // The file containing the html for the component
  styleUrl: './app.component.css'             // The file cotaining css for the component
})
// export allows processes outside this component to access things defined in the component 
// 
// any data or methods you want to use must be export'd from Typescript for the 
// To use One-Way Binding for data defined in this code in the HTML:  {{variable-name}}
export class AppComponent {
  pageHeading = "Welcome to AHBC - C#/Java- Contact Info Submission"
}
