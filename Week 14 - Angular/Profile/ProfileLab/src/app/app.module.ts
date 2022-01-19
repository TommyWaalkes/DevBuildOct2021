import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProfileDisplayComponent } from './profile-display/profile-display.component';
import { EditProfileComponent } from './edit-profile/edit-profile.component';

@NgModule({
  declarations: [
    AppComponent,
    ProfileDisplayComponent,
    EditProfileComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
