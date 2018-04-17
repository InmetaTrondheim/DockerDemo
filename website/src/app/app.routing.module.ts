import { RouterModule, Routes } from '@angular/router';
import { AddPersonComponent } from './add-person/add-person.component';
import { PeopleComponent } from './people/people.component';
import { NgModule } from '@angular/core';


const appRoutes: Routes = [
    { path: '', pathMatch: 'full', component: PeopleComponent },
    { path: 'addPerson',  pathMatch: 'full', component: AddPersonComponent },
];

@NgModule({
    imports: [RouterModule.forRoot(appRoutes)],
    exports: [RouterModule]
})
export class AppRoutingModule {
}
