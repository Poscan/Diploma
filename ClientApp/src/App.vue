<template>
  <v-card>
    <v-app-bar color="#2c3e50">
      <v-toolbar-title>
        <router-link to="/">
          <span style="color: #535556">Students</span>
          <span style="color: #4e7bb0">GO</span>
        </router-link>
      </v-toolbar-title>

      <v-spacer></v-spacer>

      <div class="finder">
        <v-autocomplete hide-no-data hide-details hide rounded flat placeholder="Поиск" prepend-icon="mdi-magnify" />
      </div>

      <v-spacer></v-spacer>

      <v-btn icon>
        <v-icon>mdi-heart</v-icon>
      </v-btn>

      <v-btn icon>
        <v-icon>mdi-dots-vertical</v-icon>
      </v-btn>

      <template v-slot:extension>
        <v-tabs align-with-title>
          <v-tab>
            <router-link class="link" to="/">Конференции</router-link>
          </v-tab>
          <v-tab>
            <router-link class="link" to="/about">About</router-link>
          </v-tab>
        </v-tabs>
      </template>
    </v-app-bar>
    <section class="content">
      <router-view />
    </section>
  </v-card>
</template>

<style>
html,
body {
  margin: 0;
  padding: 0;
  height: 100%;
  box-sizing: border-box !important;
  background-color: #f7f8f9;
  font-family: Roboto;
  font-style: normal;
  font-weight: normal;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}

.v-sheet.v-card:not(.v-sheet--outlined) {
  box-shadow: none !important;
}

img {
  margin: 0 auto;
  object-fit: contain;
}

header {
  position: fixed !important;
  z-index: 999;
  width: 100%;
}

a {
  text-decoration: none;
  color: #898989;
}

.content {
  padding-top: 112px;
}

.v-sheet.v-card {
  border-radius: 0 !important;
}

.v-text-field .v-input__append-inner {
  display: none !important;
}

.v-input__append-outer,
.v-input__prepend-outer {
  margin-left: 12px !important;
}

.v-autocomplete.v-input > .v-input__control > .v-input__slot {
  margin-left: -12px !important;
}

.v-sheet.v-app-bar.v-toolbar:not(.v-sheet--outlined) {
  box-shadow: none !important;
}

.v-toolbar__content {
  background: #ffffff;
  padding: 4px 40px !important;
}

.v-toolbar__extension {
  background-color: #f7f8f9;
  border: 2px 0 !important;
  border: solid #e6e7e7;
}

.v-slide-group__content {
  justify-content: center;
}

.v-tabs-slider {
  background-color: #4e7bb0 !important;
}

.finder {
  display: inline;
  width: 555px;
  max-width: 555px;
  padding: 2px;
  background: #f7f8f9;
  border: 2px solid #ebeced;
  text-align: left;
  border-radius: 5px;
}

.title-finder {
  display: inline-block;
  line-height: 24px;
}

/* ____________________________________________________ */

.v-avatar {
  border-radius: 0 !important;
}

.max-width {
  width: 100%;
  text-align: justify;
  border: 0 !important;
  border-bottom: 2px solid rgba(0, 0, 0, 0.12) !important;
}

.max-width-mini {
  width: 100%;
  text-align: justify;
  border: 0 !important;
}

.line {
  margin: 0 32px;
  margin-bottom: 16px;
}

.line2 {
  margin: 16px 32px;
}

.mhor-32 {
  margin: 0 32px;
}

.mhor-16 {
  margin: 0 16px;
}

.mleft-24 {
  margin-left: 24px;
  margin-bottom: 16px;
}

.sign-up {
  padding: 0 15px !important;
  border-radius: 5px;
}

.count {
  display: inline-block;
  margin-left: 5px;
  margin-right: 15px;
}
</style>
