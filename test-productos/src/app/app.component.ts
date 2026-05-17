import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ProductoListComponent } from "./components/producto-list/producto-list.component";

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, ProductoListComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})

export class AppComponent {
  title = 'productos';
}
