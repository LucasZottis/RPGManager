// src/app/shared/components/toast/toast.service.ts

import { Injectable, signal, computed } from '@angular/core';
import { Toast, ToastType } from '../../Models/toast.model';

@Injectable({ providedIn: 'root' })
export class ToastService {
  private readonly _toasts = signal<Toast[]>([]);

  readonly toasts = computed(() => this._toasts());

  show(message: string, type: ToastType = 'info', durationMs = 4000): void {
    const id = crypto.randomUUID();
    const toast: Toast = { id, type, message, durationMs };

    this._toasts.update(current => [...current, toast]);

    setTimeout(() => this.dismiss(id), durationMs);
  }

  success(message: string, durationMs?: number): void {
    this.show(message, 'success', durationMs);
  }

  error(message: string, durationMs?: number): void {
    this.show(message, 'error', durationMs);
  }

  warning(message: string, durationMs?: number): void {
    this.show(message, 'warning', durationMs);
  }

  info(message: string, durationMs?: number): void {
    this.show(message, 'info', durationMs);
  }

  dismiss(id: string): void {
    this._toasts.update(current => current.filter(t => t.id !== id));
  }
}