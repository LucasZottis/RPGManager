import { Routes } from '@angular/router';

export const AUTHENTICATION_ROUTES: Routes = [
    {
        path: "",
        loadComponent: () => import('./authentication-layout/authentication-layout.component').then(p => p.AuthenticationLayoutComponent),
        children: [
            {
                path: "login",
                loadComponent: () => import('./pages/authentication-page/authentication-page.component').then(p => p.AuthenticationPageComponent),
            },
            {
                path: "register",
                loadComponent: () => import('./pages/register-user-page/register-user-page.component').then(p => p.RegisterUserPageComponent),
            },
        ]
    }
];
