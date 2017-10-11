<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

<xsl:template match="/">
  <html>
  <head>
    <title>Wood Stock</title>
  </head>
  <body>
  <h2>Wood Stock</h2>
  <table border="1">
    <tr bgcolor="#9acd32">
      <th>Item Code</th>
      <th>Item Description</th>
      <th>Current Count</th>
      <th>On Order</th>
    </tr>
    <xsl:for-each select="stockItems/stockItem">
    <tr>
      <td><xsl:value-of select="itemCode"/></td>
      <td><xsl:value-of select="itemDescription"/></td>
      <td style="text-align:center;"><xsl:value-of select="currentCount"/></td>
      <td style="text-align:center;"><xsl:value-of select="onOrder"/></td>
    </tr>
    </xsl:for-each>
  </table>
  </body>
  </html>
</xsl:template>

</xsl:stylesheet>