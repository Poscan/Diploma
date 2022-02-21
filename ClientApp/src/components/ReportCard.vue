<template>
  <v-app>
    <div class="report-card">
      <div class="text-header m-16">Тема доклада</div>
      <div class="image-header zag"></div>
      <br />
      <div class="text-header m-16">Докладчик</div>
      <div class="line p-m-0"></div>
      <div class="text-subheader p-mt-16">Соучастники</div>
    </div>
  </v-app>
</template>

<script lang="ts">
import Vue from "vue";
import Conference from "@/services/models/Conference";

export default Vue.extend({});
</script>

<style>
.report-card {
  text-align: center;
  border: 1px black solid;
  padding: 16px;
  margin: 16px;
  width: 160px;
  display: inline-block;
}

.p-mb-16 {
  margin-bottom: 16px !important;
}

.p-mt-16 {
  margin-top: 16px;
}

.p-m-0 {
  margin: 0 !important;
}
</style>
