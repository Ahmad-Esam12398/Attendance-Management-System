<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:template match="/">
		<html>
			<head>
				<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"/>
				<title>Attendance Data</title>
			</head>
			<body>
				<table class="table table-striped">
					<thead class="thead-dark">
						<tr>
							<!-- Create a header for each sub-element -->
							<xsl:for-each select="//student[1]/*">
								<th>
									<xsl:value-of select="name()"/>
								</th>
							</xsl:for-each>
						</tr>
					</thead>
					<!-- Create a row for each child element -->
					<xsl:for-each select="//student">
						<tr>
							<!-- Create a cell for each sub-element -->
							<xsl:for-each select="./*">
								<td>
									<xsl:attribute name="class">
										<xsl:choose>
											<xsl:when test=".='Absent'">bg-danger</xsl:when>
											<xsl:when test=".='Present'">bg-success</xsl:when>
										</xsl:choose>
									</xsl:attribute>
									<xsl:value-of select="."/>
								</td>
							</xsl:for-each>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>