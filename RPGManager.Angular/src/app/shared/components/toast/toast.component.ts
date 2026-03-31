// src/app/shared/components/toast/toast.component.ts

import { Component, inject } from '@angular/core';
import { NgClass } from '@angular/common';
import { ToastService } from '../../Services/Toast/toast.service';

@Component({
  selector: 'rpg-toast',
  standalone: true,
  imports: [NgClass],
  templateUrl: './toast.component.html',
  styleUrl: './toast.component.scss'
})
export class ToastComponent {
  protected readonly toastService = inject(ToastService);
}