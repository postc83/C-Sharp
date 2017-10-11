<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

<xsl:template match="/">
  <html>
  <head>
    <title>Wood Stock</title>
  </head>
  <body style="background-color:#3e94ec; font-family: Roboto, helvetica, arial, sans-serif; font-size: 16px; color:#666B85">
  <div style="max-width: 700px; padding: 10px; margin: auto">
  <h2 style="color:white; font-size: 30px">Wood Stock - Current Stock List</h2>
  <table style="border-radius:3px; border-collapse: collapse">
    <tr style="background:#1b1e24; color:#d5dde5; font-size:23px; font-weight: 100; border-top-left-radius:10px">
      <th style="padding:15px">Item Code</th>
      <th style="padding:15px">Item Description</th>
      <th style="padding:15px">Current Count</th>
      <th style="padding:15px">On Order</th>
    </tr>
    <xsl:for-each select="stockItems/stockItem">

      <xsl:choose>
        <xsl:when test="@id mod 2 = 0">
          <tr bgcolor="#EBEBEB">
	  <td style="padding:5px; border-bottom:1px solid #9ea7af; border-right: 1px solid #9ea7af"><xsl:value-of select="itemCode"/></td>
	  <td style="padding:5px; border-bottom:1px solid #9ea7af; border-right: 1px solid #9ea7af"><xsl:value-of select="itemDescription"/></td>
	  <td style="text-align:center;padding:5px; border-bottom:1px solid #9ea7af; border-right: 1px solid #9ea7af"><xsl:value-of select="currentCount"/></td>
	  <td style="text-align:center;padding:5px; border-bottom:1px solid #9ea7af"><xsl:value-of select="onOrder"/></td>
          </tr>
        </xsl:when>
        <xsl:otherwise>
          <tr bgcolor="white">
	  <td style="padding:5px; border-bottom:1px solid #9ea7af; border-right: 1px solid #9ea7af"><xsl:value-of select="itemCode"/></td>
	  <td style="padding:5px; border-bottom:1px solid #9ea7af; border-right: 1px solid #9ea7af"><xsl:value-of select="itemDescription"/></td>
	  <td style="text-align:center; padding:5px; border-bottom:1px solid #9ea7af; border-right: 1px solid #9ea7af"><xsl:value-of select="currentCount"/></td>
	  <td style="text-align:center; padding:5px; border-bottom:1px solid #9ea7af"><xsl:value-of select="onOrder"/></td>
          </tr>
        </xsl:otherwise>
      </xsl:choose>

      
    </xsl:for-each>
  </table>
  </div>
  </body>
  </html>
</xsl:template>

</xsl:stylesheet>