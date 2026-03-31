import { Routes } from '@angular/router';

export const routes: Routes = [
    {
        path: "",
        loadChildren: () => import('./authentication/authentication.routes').then(r => r.AUTHENTICATION_ROUTES)
    },
    {
        path: "",
        loadChildren: () => import('./character-creation/character-builder.routes').then(r => r.CHARACTERE_BUILDER_ROUTES)
    },
];
