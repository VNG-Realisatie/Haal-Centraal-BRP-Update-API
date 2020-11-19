/*
 * BRP Update API
 * Met deze API kun je opvragen welke door jou gevolgde personen zijn gewijzigd in de BRP. Je kunt je abonneren op een persoon die je wilt volgen, en je kunt opvragen welke personen door jou worden gevolgd. Je kunt deze API gebruiken in combinatie met de BRP bevragen API, bijvoorbeeld om lokale kopiegegevens actueel te houden.
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import org.openapitools.client.model.VolgindicatieRaadplegen;

/**
 * VolgindicatieCollectie
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2020-11-19T08:46:35.638Z[Etc/UTC]")
public class VolgindicatieCollectie {
  public static final String SERIALIZED_NAME_VOLGINDICATIES = "volgindicaties";
  @SerializedName(SERIALIZED_NAME_VOLGINDICATIES)
  private List<VolgindicatieRaadplegen> volgindicaties = null;


  public VolgindicatieCollectie volgindicaties(List<VolgindicatieRaadplegen> volgindicaties) {
    
    this.volgindicaties = volgindicaties;
    return this;
  }

  public VolgindicatieCollectie addVolgindicatiesItem(VolgindicatieRaadplegen volgindicatiesItem) {
    if (this.volgindicaties == null) {
      this.volgindicaties = new ArrayList<>();
    }
    this.volgindicaties.add(volgindicatiesItem);
    return this;
  }

   /**
   * Get volgindicaties
   * @return volgindicaties
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<VolgindicatieRaadplegen> getVolgindicaties() {
    return volgindicaties;
  }


  public void setVolgindicaties(List<VolgindicatieRaadplegen> volgindicaties) {
    this.volgindicaties = volgindicaties;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    VolgindicatieCollectie volgindicatieCollectie = (VolgindicatieCollectie) o;
    return Objects.equals(this.volgindicaties, volgindicatieCollectie.volgindicaties);
  }

  @Override
  public int hashCode() {
    return Objects.hash(volgindicaties);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class VolgindicatieCollectie {\n");
    sb.append("    volgindicaties: ").append(toIndentedString(volgindicaties)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

