import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { OrbcoreComponent } from './Views/orbcore/orbcore.component';
import { AutsisComponent } from './Views/autsis/autsis.component';
import { EmailComponent } from './Views/email/email.component';


const routes: Routes = [
  { path: 'orbcore', component: OrbcoreComponent },
  { path: 'autsis', component: AutsisComponent },
  { path: 'email', component: EmailComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
