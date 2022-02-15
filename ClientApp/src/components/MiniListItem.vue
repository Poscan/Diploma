<template>
  <div>
    <v-app>
      <v-card class="mx-auto max-width-mini" outlined>
        <v-card-title class="v-card-mini">
          <v-list-item two-line>
            <v-list-item-avatar size="40">
              <img :src="conference.pictureUrl" />
            </v-list-item-avatar>
            <v-list-item-content>
              <v-list-item-title>
                <div class="title-text-mini mb-1">
                  {{ conference.name }}
                </div>
              </v-list-item-title>
              <v-list-item-subtitle>
                <div class="subtitle-text-mini">
                  {{ conference.organisationName }}
                </div>
              </v-list-item-subtitle>
            </v-list-item-content>
          </v-list-item>
        </v-card-title>
        <v-divider class="mhor-16" />
      </v-card>
    </v-app>
  </div>
</template>

<script lang="ts">
import Vue from "vue";
import Conference from "@/services/models/Conference";

export default Vue.extend({
  props: {
    conference: Conference,
  },
});
</script>

<style>
.v-card-mini {
  padding: 8px 0 !important;
}

.title-text-mini {
  width: 100px;
  display: inline-block;
  font-size: 14px !important;
}

.subtitle-text-mini {
  width: 100px;
  display: inline-block;
  font-size: 12px !important;
}
</style>
