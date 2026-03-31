// src/app/shared/components/toast/toast.model.ts

export type ToastType = 'success' | 'error' | 'warning' | 'info';

export interface Toast {
    id: string;
    type: ToastType;
    message: string;
    durationMs: number;
}