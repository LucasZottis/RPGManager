import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ToastComponent } from './shared/components/toast/toast.component';

@Component({
  selector: 'rpg-root',
  standalone: true,
  imports: [RouterOutlet, ToastComponent],
  template: '<rpg-toast /> <router-outlet />',
})
export class AppComponent {

}
