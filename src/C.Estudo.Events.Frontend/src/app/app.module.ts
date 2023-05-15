import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { ToastrModule } from 'ngx-toastr';

import {
  MatToolbarModule,
  MatSidenavModule,
  MatListModule,
  MatButtonModule,
  MatIconModule,
  MatTableModule,
  MatGridListModule,
  MatInputModule,
} from '@angular/material';

import { OrbcoreComponent } from './Views/orbcore/orbcore.component';
import { EmailComponent } from './Views/email/email.component';
import { AutsisComponent } from './Views/autsis/autsis.component';
import { NavbarComponent } from './Views/layouts/navbar.component';
import { OrbcoreService } from './services/orbcore.service';
import { AutsisService } from './services/autsis.service';
import { EmailService } from './services/email.service';


@NgModule({
  declarations: [AppComponent, NavbarComponent, OrbcoreComponent, EmailComponent, AutsisComponent],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    MatSidenavModule,
    MatListModule,
    MatButtonModule,
    MatIconModule,
    MatTableModule,
    MatGridListModule,
    MatInputModule,
    FormsModule,
    HttpClientModule,
    ToastrModule.forRoot()
  ],
  providers: [OrbcoreService, AutsisService, EmailService],
  bootstrap: [AppComponent],
  exports: [ToastrModule]
})
export class AppModule {}
